using System;


namespace StudentAttendanceSystem2
{
    public class Customize
    {

        //For adding and removing students

        public static void CustomizeStudents()
        {
            string customize;
    
            Console.WriteLine("Press A/a to add a student");
            Console.WriteLine("Press R/r to remove a student");
            customize = Console.ReadLine().ToUpper();

            if (customize.Equals("A"))
            {
                Console.WriteLine("Enter your Full Name: ");
                string name = Console.ReadLine();
                Console.WriteLine(" Student:" + name + " has been added");             
            }
            else if (customize.Equals("R"))
            {
                Console.WriteLine("Enter the Full Name: ");
                string name = Console.ReadLine();
                Console.WriteLine(" Student:" + name + " has been removed");            
            }
            else
            {
                Console.WriteLine("Invalid keyword please try again");
            }
        }
    }
}

