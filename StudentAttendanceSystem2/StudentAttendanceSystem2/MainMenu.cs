using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentAttendanceSystem2;

namespace SAS.BL
{
    public class MainMenu:RecordAttendance
    {

        //The main menu where the user will select an option to be executed.

        public void ShowMainMenu()
        {

            char optionSelected;

            Console.WriteLine("<><><><><>|----------------------------------------------|<><><><><>");
            Console.WriteLine("<><><><><>|~Welcome to the Student Attendance System~~~~~|<><><><><>");
            Console.WriteLine("<><><><><>|----------------------------------------------|<><><><><>");
            Console.WriteLine("<><><><><>|~Press R/r to Record the Student's Attendance~|<><><><><>");
            Console.WriteLine("<><><><><>|~Press V/v to View the List of Students~~~~~~~|<><><><><>");
            Console.WriteLine("<><><><><>|~Press C/C to Customize a Student~~~~~~~~~~~~~|<><><><><>");
            Console.WriteLine("<><><><><>|~Press E/e to Exit the program~~~~~~~~~~~~~~~~|<><><><><>");
            Console.WriteLine("<><><><><>|----------------------------------------------|<><><><><>");
            optionSelected = Console.ReadLine()[0];

            switch (Char.ToUpper(optionSelected))
            {
                case 'R':
                   RecordStudentAttendance();
                    break;
                case 'V':
                    StudentsList list = new StudentsList();
                    StudentsList.StudentsInfo();

                    break;
                case 'C':
                    Customize custom = new Customize();
                    Customize.CustomizeStudents();
                    break;
                case 'E':
                    Console.WriteLine("...........................");
                    Console.WriteLine("...........................");
                    Console.WriteLine("......Ending Program.......");
                    Console.WriteLine("...........................");
                    Console.WriteLine("...........................");
                    break;
            }
        }
    }
}
