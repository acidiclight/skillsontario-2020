/* SkillsOntario Contestant Manager
 * 1.0.0.0 Final Revision: Michael VanOverbeek, June 17th, 2020
 * Create, update, delete, and analyze student data across all SkillsOntario contests.
 *
 * This file defines the main behaviour of the program and its primary UI - including but not limited to:
 *  - Reading in schoolboard and student info from disk
 *  - Displaying the data in the UI
 *  - Saving student info to disk
 *  - Applying sorts and filters
 *  - Deleting student data
 * This is the largest file in the project.
  */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SkillsOntario.ContestentManager
{
    public partial class MainWindow : Form
    {
        // How shall we search through each item?
        private FilterType filterType = FilterType.None;

        // What value are we looking for when filtering?
        private string filterValue = "";

        // How should we sort contestants in the list?
        private ContestantSortType sortType = ContestantSortType.Id;

        /// <summary>
        /// The window title of the schoolboard message box.
        /// </summary>
        private readonly string SCHOOLBOARD_INSTRUCTIONS_CAPTION = "Setup incomplete.";

        /// <summary>
        /// The text to be displayed in the schoolboard message box.
        /// </summary>
        private string SCHOOLBOARD_INSTRUCTIONS => $@"No schoolboard information was found, therefore we regret to inform you that this program can't launch. Please add information for each available schoolboard to the following file path. Place each schoolboard's name on its own line. A blank file has been created for you.

{this.SchoolboardsFilePath}";

        // Constant value representing the first few bytes of a typical binary Contestant file that we can use to make sure we don't try to load
        // files that aren't Contestant data. "SoN7" is a mangled algorithm for "Skills Ontario", 7 looks like a "T" if you squint.
        private readonly byte[] CONTESTANT_FILE_MAGIC_NUMBER = Encoding.UTF8.GetBytes("SoN7");

        /// <summary>
        /// A list representing all of the contestants of SkillsOntario.
        /// </summary>
        private List<Contestant> contestants = new List<Contestant>();

        /// <summary>
        /// Gets a filesystem path to the folder where contestant information is stored.
        /// </summary>
        public string ContestantsDirectoryPath => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Contestants");

        /// <summary>
        /// Gets a path to the file where schoolboard information is stored.
        /// </summary>
        public string SchoolboardsFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "boards.txt");

        // A list of choolsable schoolboards when creating a new contestant.
        public List<string> SchoolBoards = new List<string>();

        /// <summary>
        /// Gets a list of all contestants, sorted with the selected sort type.
        /// </summary>
        public IEnumerable<Contestant> SortedContestants
        {
            get
            {
                IEnumerable<Contestant> sorted = contestants;
                
                switch (sortType)
                {
                    case ContestantSortType.Id:
                        sorted = contestants.OrderBy(x => x.Id);
                        break;
                    case ContestantSortType.FirstName:
                        sorted = contestants.OrderBy(x => x.FirstName);
                        break;
                    case ContestantSortType.LastName:
                        sorted = contestants.OrderBy(x => x.LastName);
                        break;
                    case ContestantSortType.Score:
                        sorted = contestants.OrderByDescending(x => x.Score);
                        break;
                }

                return sorted;
            }
        }

        /// <summary>
        /// Gets a public list of all contestants that can only be looped through and not modified.
        /// </summary>
        public IEnumerable<Contestant> Contestants => contestants;

        // I'm just....not going to touch this.
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads all school districts from a text file and displays an error if none are found.
        /// </summary>
        private void LoadSchoolBoards()
        {
            // If the boards.txt file isn't found, tell the user they need to do something first.
            if (!File.Exists(SchoolboardsFilePath) || string.IsNullOrWhiteSpace(File.ReadAllText(SchoolboardsFilePath).Trim()))
            {
                // Create a blank file for the user to edit.
                File.WriteAllText(SchoolboardsFilePath, "");

                // Show a message box with setup instructions.
                MessageBox.Show(this, SCHOOLBOARD_INSTRUCTIONS, SCHOOLBOARD_INSTRUCTIONS_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Close the program... there's no point displaying any more UI.
                // Setup isn't completed.
                Environment.Exit(0);
            }
            else
            {
                // Clear the schoolboards list.
                this.SchoolBoards.Clear();

                // Add a hard-coded "None" value as a fallback.
                this.SchoolBoards.Add("None");

                // Read the boards.txt file in and add every board to the list.
                // This is one line of code. I'll filter out blank lines though.
                this.SchoolBoards.AddRange(File.ReadAllLines(this.SchoolboardsFilePath).Where(x => !string.IsNullOrWhiteSpace(x)));
            }
        }

        /// <summary>
        /// Sets up the initial GUI strate of the "Filter By" feature.
        /// </summary>
        private void InitializeFilterUI()
        {
            // Clear any sample data in the UI.
            cmbFilterType.Items.Clear();
            txtFilterValue.Text = "";

            // Add all valid filters to the Filter Type selection.
            foreach (var name in Enum.GetNames(typeof(FilterType)))
            {
                cmbFilterType.Items.Add(MakeFriendlyName(name));
            }

            // Set the default "Filter By" value in the GUI.
            cmbFilterType.SelectedIndex = (int)this.filterType;
        }

        /// <summary>
        /// LOads any contestant files from disk and populates the internal contestant list with them.
        /// </summary>
        private void LoadContestantsFromDisk()
        {
            // Create the contestands folder if it doesn't exist.
            if (!Directory.Exists(this.ContestantsDirectoryPath))
            {
                Directory.CreateDirectory(this.ContestantsDirectoryPath);
            }

            // Clear out the existing list of contestants in memory to make way for the loaded list.
            this.contestants.Clear();

            // Loop through every file in the contestants folder.
            foreach (var contestantFile in Directory.GetFiles(this.ContestantsDirectoryPath))
            {
                // Get some info about the file
                var fileInfo = new FileInfo(contestantFile);

                // Sanity check, only allow .dat files to be loaded.
                if (fileInfo.Extension.ToLower() == ".dat")
                {
                    // Open up a file stream to read in the file.
                    using (var stream = File.OpenRead(contestantFile))
                    {
                        // Open up a binary reader to make reading the file easier.
                        using (var reader = new BinaryReader(stream, Encoding.UTF8))
                        {
                            // Read in what should be the magic number and check it against the value we expect.
                            // If this check fails, DO NOT load the file.
                            var magicNumber = reader.ReadBytes(CONTESTANT_FILE_MAGIC_NUMBER.Length);

                            if (magicNumber.SequenceEqual(CONTESTANT_FILE_MAGIC_NUMBER))
                            {
                                // Now we can start reading the student info in.
                                // Start by creating the object we'll store the info in.
                                var student = new Contestant();

                                // Read in the ID and name
                                student.Id = reader.ReadInt32();
                                student.FirstName = reader.ReadString();
                                student.LastName = reader.ReadString();
                                student.Email = reader.ReadString();

                                // Let's branch this off into a dedicated function for re-use.
                                student.DateOfBirth = ReadDate(reader);

                                // Schoolboard is easy. Just read the id from the file and if it's outside the range
                                // then choose "None".
                                int boardId = reader.ReadInt32();
                                student.SchoolBoard = (boardId >= 0 && boardId < SchoolBoards.Count) ? SchoolBoards[boardId] : SchoolBoards[0];

                                // Contest is just a string. Could be an id as well eventually.
                                student.Contest = reader.ReadString();

                                // Read in the score value
                                student.Score = reader.ReadSingle();

                                // This is for our own use, for deletion and editing.
                                student.FileName = contestantFile;

                                // Add the student to the list.
                                contestants.Add(student);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Reads a date from a BinaryReader as a 64-bit integer representing windows ticks.
        /// </summary>
        /// <param name="reader">The BinaryReader to read from.</param>
        /// <returns>The DateTime representing the stored date.</returns>
        private DateTime ReadDate(BinaryReader reader)
        {
            long ticks = reader.ReadInt64();
            var date = new DateTime(ticks, DateTimeKind.Utc);
            return date;
        }

        // Reloads all information from disk.
        private void ReloadAllInformation()
        {
            this.LoadSchoolBoards();
            this.LoadContestantsFromDisk();

            this.ReloadListView();
        }

        /// <summary>
        /// Initializes the state of the "Sort By" feature.
        /// </summary>
        private void InitializeSortUI()
        {
            // Clear any sample data that's in the drop down.
            this.cmbSortType.Items.Clear();

            // Add all valid Sort Types to the drop down.
            foreach (var name in Enum.GetNames(typeof(ContestantSortType)))
            {
                // Special case for "ID" because "Id" looks weird.
                if (name == "Id")
                {
                    cmbSortType.Items.Add(name.ToUpper());
                } 
                else
                {
                    cmbSortType.Items.Add(MakeFriendlyName(name));
                }
            }

            // Set the default Sort Type in the UI.
            this.cmbSortType.SelectedIndex = (int)sortType;
        }

        /// <summary>
        /// Gets a user-friendly name from a C# identifier.  Capitalizes the first letter, and adds a space before each capital in the identifier.
        /// identifierName should become "Identifier Name".
        /// </summary>
        /// <param name="identifier">The unfriendly C# identifier to friendly-ify.</param>
        /// <returns>The UI-friendly version of the identifier.</returns>
        private string MakeFriendlyName(string identifier)
        {
            string friendly = "";
            foreach(char character in identifier)
            {
                if (char.IsUpper(character))
                {
                    friendly += " " + character;
                }
                else
                {
                    friendly += character;
                }

                if (friendly.Length == 1)
                {
                    friendly = friendly.ToUpper();
                }
            }

            return friendly.Trim();
        }

        /// <summary>
        /// Returns the next incremental Student ID, ensuring that no two IDs are the same.
        /// </summary>
        /// <returns>A guaranteed unique Student ID.</returns>
        private int GetNextId()
        {
            // The id we intend to use.
            int id = 0;

            // This loop will increment the id until we can't find a student with this id.
            while (contestants.Any(x=>x.Id == id))
            {
                id++;
            }

            // Return it.
            return id;
        }

        /// <summary>
        /// Saves the given Contestant to a file on disk.
        /// </summary>
        /// <param name="contestant">The contestant to save.</param>
        private void SaveContestant(Contestant contestant)
        {
            // Get the path to the contestant file
            string filePath = contestant.FileName;

            // If that path is empty...create a new one based on the ID
            if (string.IsNullOrWhiteSpace(filePath))
            {
                filePath = Path.Combine(ContestantsDirectoryPath, contestant.FormattedId + ".dat");
                contestant.FileName = filePath;
            }

            // Open a writeable stream on the file
            using (var stream = File.Open(filePath, FileMode.OpenOrCreate))
            {
                stream.Position = 0;
                using (var writer = new BinaryWriter(stream, Encoding.UTF8))
                {
                    // Write the magic number.
                    writer.Write(CONTESTANT_FILE_MAGIC_NUMBER);

                    // Write the ID, name, and email
                    writer.Write(contestant.Id);
                    writer.Write(contestant.FirstName);
                    writer.Write(contestant.LastName);
                    writer.Write(contestant.Email);

                    // Write the date of birth, in ticks.
                    writer.Write(contestant.DateOfBirth.Ticks);

                    // Schoolboard time.
                    if (SchoolBoards.Contains(contestant.SchoolBoard))
                    {
                        writer.Write(SchoolBoards.IndexOf(contestant.SchoolBoard));
                    }
                    else
                    {
                        writer.Write(0);
                    }

                    // Contest name and score.
                    writer.Write(contestant.Contest);
                    writer.Write(contestant.Score);

                    // Done.
                }
            }
        }

        /// <summary>
        /// Applies the selected Filter to the given list of Contestants.
        /// </summary>
        /// <param name="contestantsToFilter">The list of Contestants to filter.</param>
        /// <returns>The filtered list of Contestants.</returns>
        private IEnumerable<Contestant> Filter(IEnumerable<Contestant> contestantsToFilter)
        {
            var filtered = contestantsToFilter;

            switch (filterType)
            {
                case FilterType.LastName:
                    filtered = filtered.Where(x => x.LastName.ToLower().Contains(filterValue.ToLower()));
                    break;
                case FilterType.District:
                    filtered = filtered.Where(x => x.SchoolBoard.ToLower().Contains(filterValue.ToLower()));
                    break;
                case FilterType.Birthdate:
                    filtered = filtered.Where(x => x.FormattedDateOfBirth.Contains(filterValue.ToLower()));
                    break;
                case FilterType.Contest:
                    filtered = filtered.Where(x => x.Contest.ToLower().Contains(filterValue.ToLower()));
                    break;
            }

            return filtered;
        }

        /// <summary>
        /// Repopulates the GUI with student information without re-reading the data from disk.
        /// </summary>
        private void ReloadListView()
        {
            // Clear any existing data from the UI.
            this.lstStudents.Items.Clear();

            // Iterate through the filtered and sorted list of Contestants.
            foreach (var contestant in Filter(SortedContestants))
            {
                var listItem = new ListViewItem();
                listItem.Text = contestant.FormattedId;
                listItem.SubItems.Add(contestant.FullName);
                listItem.SubItems.Add(contestant.FormattedDateOfBirth);
                listItem.SubItems.Add(contestant.Contest);
                listItem.SubItems.Add((Math.Floor(contestant.Score * 100)).ToString());
                listItem.Tag = contestant;

                this.lstStudents.Items.Add(listItem);
            }

            // This is where we initialize the list of contests for the "Show Top 3 For" feature.
            var allContestNames = this.contestants.Select(x => x.Contest).Where(x => !string.IsNullOrWhiteSpace(x));

            cmbTopThreeContestList.Items.Clear();

            foreach (var contest in allContestNames)
            {
                if (!cmbTopThreeContestList.Items.Contains(contest))
                {
                    cmbTopThreeContestList.Items.Add(contest);
                }
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            // Initializes all of the UI for the toolbar (sorting and filtering)
            this.InitializeSortUI();
            this.InitializeFilterUI();

            // Reload everything.
            this.ReloadAllInformation();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            // Ask the user if they're sure they'd like to delete all students.
            var result = MessageBox.Show(this, "Are you sure you want to delete all students from the directory? This action cannot be undone.", "Clear all", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Did the user click Yes?
            if (result == DialogResult.Yes)
            {
                // Well, I guess it's time for some r/MaliciousCompliance.
                if (Directory.Exists(ContestantsDirectoryPath))
                {
                    Directory.Delete(ContestantsDirectoryPath, true);
                }

                // Goodbye, data.
                this.ReloadAllInformation();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var editor = new EditorDialog(this);
            var result = editor.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Get the created contestant object.
                var contestant = editor.Contestant;

                // Get a new ID for the contestant
                contestant.Id = GetNextId();

                // And save the contestant to a file.
                this.SaveContestant(contestant);

                // Add it to our list.
                this.contestants.Add(contestant);

                // Reload the list.
                this.ReloadListView();
            }
        }

        private void lstStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstStudents.SelectedItems.Count > 0)
            {
                this.btnDelete.Enabled = true;
                this.btnEdit.Enabled = true;
            }
            else
            {
                this.btnDelete.Enabled = false;
                this.btnEdit.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Ask the user if they're sure they want to delete this item.
            var result = MessageBox.Show(this, "Are you sure you want to delete this contestant? This action cannot be undone.", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Get the selected contestant
                var contestant = lstStudents.SelectedItems[0].Tag as Contestant;

                // Delete the file.
                File.Delete(contestant.FileName);

                // Delete the contestant from memory.
                this.contestants.Remove(contestant);

                // Reload the list.
                this.ReloadListView();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var editor = new EditorDialog(this, lstStudents.SelectedItems[0].Tag as Contestant);
            var result = editor.ShowDialog();

            if (result == DialogResult.OK)
            {
                SaveContestant(editor.Contestant);
                ReloadListView();
            }
        }

        private void cmbSortType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.sortType = (ContestantSortType)this.cmbSortType.SelectedIndex;
            this.ReloadListView();
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            filterType = (FilterType)cmbFilterType.SelectedIndex;
            filterValue = txtFilterValue.Text;
            ReloadListView();
        }

        private void btnShowTopThree_Click(object sender, EventArgs e)
        {
            if (cmbTopThreeContestList.SelectedIndex >= 0)
            {
                var topContestants = this.contestants.Where(x => x.Contest == cmbTopThreeContestList.Text).OrderByDescending(x => x.Score).Take(3);

                var stringBuilder = new StringBuilder();
                stringBuilder.AppendLine($"For the SkillsOntario {cmbTopThreeContestList.Text} contest, the top {topContestants.Count()} contestant(s) are as follows:");
                stringBuilder.AppendLine(Environment.NewLine);
                
                foreach (var contestant in topContestants)
                {
                    stringBuilder.AppendLine($" - {contestant.FullName.ToUpper()} from {contestant.SchoolBoard}, with a score of {Math.Floor(contestant.Score * 100)}%.");
                }

                MessageBox.Show(this, stringBuilder.ToString(), $"Top 3 students for {cmbTopThreeContestList.Text}", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(this, "Please select a contest to show.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
