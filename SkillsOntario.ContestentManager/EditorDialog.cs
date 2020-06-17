/* SkillsOntario Contestant Manager
 * 1.0.0.0 Final Revision: Michael VanOverbeek, June 17th, 2020
 * Create, update, delete, and analyze student data across all SkillsOntario contests.
 *
 * This file defines the behaviour of the Student Info Editor dialog, which is used to create and edit
 * student information.
  */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkillsOntario.ContestentManager
{
    public partial class EditorDialog : Form
    {
        // Allows us to communicate with the main program.
        private MainWindow myOwner;

        // The contestant we're editing.
        private Contestant editingContestant = null;

        // Allows our main program to see the data that the user entered.
        public Contestant Contestant => editingContestant;

        /// <summary>
        /// Creates a new instance of the EditorDialog class with the given MainWindow as the owner.
        /// </summary>
        /// <param name="owner">The MainWindow to which this dialog belongs.</param>
        public EditorDialog(MainWindow owner)
        {
            InitializeComponent();
            myOwner = owner ?? throw new ArgumentNullException(nameof(owner));
            editingContestant = new Contestant();

            // Do this for new contestants so  that we know this contestant's id is invalid.
            editingContestant.Id = -1;
        }

        /// <summary>
        /// Creates a new instance of the EditorDialog class with the specified MainWindow as its owner. Populates the
        /// form data with the given Contestant's information.
        /// </summary>
        /// <param name="owner">The MainWindow to which this dialog belongs.</param>
        /// <param name="contestant">The Contestant to edit.</param>
        public EditorDialog(MainWindow owner, Contestant contestant) : this(owner)
        {
            editingContestant = contestant;
        }

        /// <summary>
        /// Populates the form with contestant data.
        /// </summary>
        private void PopulateForm()
        {
            // This makes it so hitting Enter saves the student and Esc closes without saving.
            this.AcceptButton = this.btnSave;
            this.CancelButton = this.btnCancel;

            // Clear the list of available school boards.
            this.cmbSchoolBoard.Items.Clear();
            
            // Add all of the available school boards from our owning window.
            foreach(var item in myOwner.SchoolBoards)
            {
                this.cmbSchoolBoard.Items.Add(item);
            }

            // Populate all of the raw text fields first.
            this.txtFirstName.Text = editingContestant.FirstName;
            this.txtLastName.Text = editingContestant.LastName;
            this.txtEmailAddress.Text = editingContestant.Email;
            this.txtContestName.Text = editingContestant.Contest;

            // Set the selected item of the SchoolBoard dropdown.
            this.cmbSchoolBoard.SelectedItem = editingContestant.SchoolBoard;
            
            // Set the value of the score picker to the percentage stored in the contestant data.
            this.nudScorePercentage.Value = (int)Math.Floor(editingContestant.Score * 100);
            
            // Make sure the contestant's birth date is in a valid range.
            if (editingContestant.DateOfBirth < this.dtpDateOfBirth.MinDate)
            {
                editingContestant.DateOfBirth = this.dtpDateOfBirth.MinDate;
            }
            else if (editingContestant.DateOfBirth > this.dtpDateOfBirth.MaxDate)
            {
                this.editingContestant.DateOfBirth = this.dtpDateOfBirth.MaxDate;
            }

            // Populate the date picker with the contestant's birth date.
            this.dtpDateOfBirth.Value = this.editingContestant.DateOfBirth;
        }

        /// <summary>
        /// Applies all changes made by the user to the contestant object.
        /// </summary>
        private void ApplyChanges()
        {
            this.editingContestant.FirstName = txtFirstName.Text;
            this.editingContestant.LastName = txtLastName.Text;
            this.editingContestant.Email = txtEmailAddress.Text;
            this.editingContestant.SchoolBoard = cmbSchoolBoard.Text;
            this.editingContestant.DateOfBirth = dtpDateOfBirth.Value;
            this.editingContestant.Score = (float)nudScorePercentage.Value / 100;
            this.editingContestant.Contest = txtContestName.Text;
        }

        private void EditorDialog_Load(object sender, EventArgs e)
        {
            // Populate the contestant form data. Will initialize with default values if creating a new contestant.
            this.PopulateForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate all of the fields.
            if (ValidateInformation(out string error))
            {
                // Apply the edits to the contestant and report success.
                this.ApplyChanges();
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                // Display the validation error to the user.
                MessageBox.Show(this, error, "Invalid student data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Validates the fields of the editor dialog. Returns a value indicating whether data is valid.
        /// </summary>
        /// <param name="errorMessage">The validation error message.</param>
        /// <returns>True if data is valid, false if invalid.</returns>
        private bool ValidateInformation(out string errorMessage)
        {
            bool result = true;

            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                errorMessage = "First and last name is required and cannot be blank.";
                result = false;
            }
            else if (myOwner.Contestants.Any(x => x.FirstName.ToLower() == txtFirstName.Text.Trim().ToLower() && x.LastName.ToLower() == txtLastName.Text.Trim().ToLower() && x.Id != editingContestant.Id))
            {
                errorMessage = "This student is already added as a contestant.";
                result = false;
            }
            else if (string.IsNullOrWhiteSpace(txtEmailAddress.Text))
            {
                errorMessage = "A contact email address is required.";
                result = false;
            }
            else if (cmbSchoolBoard.SelectedIndex < 1 || !myOwner.SchoolBoards.Contains(cmbSchoolBoard.Text))
            {
                errorMessage = "Please choose a school district for the student.";
                result = false;
            }
            else if (string.IsNullOrWhiteSpace(txtContestName.Text))
            {
                errorMessage = "A contest name is required.";
                result = false;
            }
            else
            {
                errorMessage = "";
            }

            return result;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Simply close the dialog without doing anything.
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
