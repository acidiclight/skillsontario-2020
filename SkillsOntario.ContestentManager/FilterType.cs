/* SkillsOntario Contestant Manager
 * 1.0.0.0 Final Revision: Michael VanOverbeek, June 17th, 2020
 * Create, update, delete, and analyze student data across all SkillsOntario contests.
 *
 * This file declares an enumeration with all of the possible filter types for the "Filter Contestants" feature. As with
 * the Sort Type enum, the program will display friendly versions of all possible values in the dropdown.
  */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsOntario.ContestentManager
{
    public enum FilterType
    {
        /// <summary>
        /// Applies no filter, displays all students.
        /// </summary>
        None,

        /// <summary>
        /// Filter students by last name.
        /// </summary>
        LastName,

        /// <summary>
        /// Filter students by birth date.
        /// </summary>
        Birthdate,

        /// <summary>
        /// Filter students by School District.
        /// </summary>
        District,

        /// <summary>
        /// Filter students by Contest Name.
        /// </summary>
        Contest
    }
}
