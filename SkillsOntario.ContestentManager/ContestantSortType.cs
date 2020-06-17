/* SkillsOntario Contestant Manager
 * 1.0.0.0 Final Revision: Michael VanOverbeek, June 17th, 2020
 * Create, update, delete, and analyze student data across all SkillsOntario contests.
 *
 * This file declares an enum containing all contestant sort types. The program uses this for the Sort By dropdown and
 * converts the names of each value to a friendly string to display in the UI.
  */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsOntario.ContestentManager
{
    public enum ContestantSortType
    {
        /// <summary>
        /// Sorts contestants in ascending order by student ID.
        /// </summary>
        Id,
        /// <summary>
        /// Sorts contestants by first name in alphabetical order.
        /// </summary>
        FirstName,
        /// <summary>
        /// Sorts contestants by last name in alphabetical order.
        /// </summary>
        LastName,
        /// <summary>
        /// Sorts contestants by highest score.
        /// </summary>
        Score
    }
}
