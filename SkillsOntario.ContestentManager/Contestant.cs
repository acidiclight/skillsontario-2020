/* SkillsOntario Contestant Manager
 * 1.0.0.0 Final Revision: Michael VanOverbeek, June 17th, 2020
 * Create, update, delete, and analyze student data across all SkillsOntario contests.
 *
 * This file declares a Contestant class, which is used to hold all data for a single student/contestant.
  */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsOntario.ContestentManager
{
    /// <summary>
    /// Represents a single contestant within the SkillsOntario contest.
    /// </summary>
    public class Contestant
    {
        /// <summary>
        /// Gets or sets the student's ID.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the first name of the student.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the student's email address.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the last name of the student.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the date of birth of the student.
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Gets or sets a percentage value indicating the student's score in the contest.
        /// </summary>
        public float Score { get; set; } = 0;

        /// <summary>
        /// Gets or sets the name of the contest in which the student is participating.
        /// </summary>
        public string Contest { get; set; }

        /// <summary>
        /// Gets or sets the schoolboard to which the student belongs.
        /// </summary>
        public string SchoolBoard { get; set; }

        /// <summary>
        /// Gets or sets the path to the contestant's file, for editing and deletion.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Gets a value representing the student's full name for displaying in the UI.
        /// </summary>
        public string FullName => FirstName + " " + LastName;

        /// <summary>
        /// Gets a zero-padded 8-digit student ID based on the value of <see cref="Contestant.Id" />.
        /// Why do it this way? Because storing the ID formatted like this in the file wastes precious disk space that can be saved
        /// because the file is a binary format and can't be easily looked at in a text editor like Notepad. You need this program to
        /// view the information stored in the file, so why waste disk space?
        /// </summary>
        public string FormattedId
        {
            get
            {
                // Get the internal ID as a string so it's easier to manipulate.
                string rawId = this.Id.ToString();

                // Add zeroes to the start until the length of the string is 8.
                while (rawId.Length < 8)
                {
                    rawId = "0" + rawId;
                }

                // And that's our value.
                return rawId;
            }
        }
        
        /// <summary>
        /// Gets a formatted birth date for display in the UI. Why do it this way? Because storing the full DateTime value in the file means C# can
        /// parse the date and time value on its own, meaning I have to write less code.
        /// </summary>
        public string FormattedDateOfBirth
        {
            get
            {
                // The value we intend to return.
                string returnValue = "";

                // If the birthdate is null, which shouldn't be possible unless there's a bug, return a simple "-" to signify "no value".
                // While this shouldn't happen in normal circumstances, this will prevent a crash.
                if (this.DateOfBirth == null)
                {
                    returnValue = " - ";
                }
                else
                {
                    // Get the day, month and year from the birthdate
                    string day = this.DateOfBirth.Day.ToString();
                    string month = this.DateOfBirth.Month.ToString();
                    string year = this.DateOfBirth.Year.ToString();

                    // Pad the day and month with zeroes if their length is 1.
                    // This just makes it look nice in my opinion.
                    if (day.Length < 2)
                    {
                        day = "0" + day;
                    }

                    if (month.Length < 2)
                    {
                        month = "0" + month;
                    }

                    returnValue = $"{day}/{month}/{year}";
                }

                return returnValue;
            }
        }
    }
}
