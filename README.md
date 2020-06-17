# 2020 SkillsOntario Virtual Coding Contest
## Michael VanOverbeek

---

This program is an entry for the **2020 SkillSOntario Virtual Coding Contest** where the goal is to create a program that can be used to theoretically manage the contest in as quick a time as possible.

This submission is written in C# on the .NET Framework, with a Windows Forms user interface.  Its purpose is to allow the creation, deletion, updating, and analyzing of student information for a group of contests.

### Features

 - Create, update, and delete student records stored in binary .dat files.
 - Store and update each student's full name, email address, school district, date of birth, and contest information.
 - See the top three contestants of any contest.
 - Sort all contestants by first name, last name, score, or student ID.
 - Filter all students by name, school district, contest, or date of birth.
 - Prevent a single student from registering twice.

### Setup Instructions

Using the program is relatively simple.  I could definitely make it more user-friendly but I'm visually impaired and designing UIs under a time limit is difficult. I've done my best.

The only preliminary setup requires is to create a file called `boards.txt` in the same folder as the EXE file.  This contains the list of available school districts when creating or updating student records.  Each line of the text file is the name of a different schoolboard.

As an example, here's the contents of a valid `boards.txt` file.

```
Upper Canada District School Board
Toronto District School Board
Hamilton
Waterloo
Algoma
Avon
Bluewater
Niagara
Durham
Erie
Halton
Hastings
Simco
```

If the file does not exist when you run the program, it will automatically create it and give you the path to it, but the file will be blank and the program will close.  The purpose of this is so that you can add and remove schoolboards without recompiling the program and without me spending an extra day adding a GUI for managing districts.

### How To Use

The main window of the program has two toolbars at the top, a data list in the middle, and four action buttons on the right.

The data list will display the IDs, names, birthdates, contests and scores of all students you add.  Click the "Create" button on the right to create a new student.  This will open a dialog box prompting you for the student's information.  Fill out the fields and hit "Save" to add the student to the directory. You can click "Cancel" to dismiss the dialog without adding a student.

You can use the "Clear All" button to delete every student in the direction. **This action cannot be reversed.**

If you want to delete or edit a single student, simply select it in the list and hit either "Delete" or "Edit".  This works perfectly with the Filter and Sort options, to make it way easier to find and update a specific student.

The top toolbar of the window is used for sorting and filtering all of the data in the list. Select from one of four sort types (ID, Last Name, Score, First Name) and the data will automatically sort. By default, data is sorted by ID.

You can also filter the data by Last Name, District, Contest, or Birth Date(\*).  All filter types are case-insensitive and support partial queries.  The Date of Birth filter is, however, text-only and it isn't friendly to select a specific date like when you're creating or editing a student.  This is because Windows Forms.

Here are some examples of what you can accomplish with sorting and filtering:

 - Show high scores of all students born in 1970 by sorting by Score and filtering by Birth Date with a value of "1970".
 - Show all students with the word "van" in their last name.
 - Find all students in the "Upper Canada District School Board"
 - Find all students with a district name containing "ha"
 - See the world-wide leaderboard across all contests
 - See the leaderboard of a single contest
 - And there's more. Try it yourself.

The second toolbar allows you to select a contest and see the Too 3 winners of the contest including their score and district.  If there are less than 3 students in the selected contest, then all students will be shown. If there are 0 students in a contest, the contest won't be available in the dropdown.

As you create and edit students, their files will automatically be updated to reflect the changes made. You do not need to save your changes when you exit the program.  However, never manually delete, rename, move or edit the files in the Contestants directory while the program is open. Otherwise you'll break it in ways I don't have time to compensate for. Best case scenario is nothing will happen but your changes won't be reflected, worst case is you'll lose data.