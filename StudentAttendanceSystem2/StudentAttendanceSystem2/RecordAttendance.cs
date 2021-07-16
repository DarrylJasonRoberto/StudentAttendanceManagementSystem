using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAttendanceSystem2
{
    public class RecordAttendance
    {

        //To track the attendance of the students

        public static void RecordStudentAttendance()
        {

            string Attendance;

            Console.WriteLine("Press P/p if you are present");
            Console.WriteLine("Press A/a if you are absent");
            Attendance = Console.ReadLine().ToUpper();

            if (Attendance.Equals("P"))
            {
                Console.WriteLine("Data has been saved");
            }
            else if (Attendance.Equals("A"))
            {
                Console.WriteLine("Reason of Absence:");
                string reason = Console.ReadLine();
                Console.WriteLine("Date of Absence(MM/DD/YY):");
                string absentdate = Console.ReadLine();
                Console.WriteLine(" You are absent on" + absentdate + "due to" + reason);
                Console.WriteLine("Data has been saved");
            }
            else
            {
                Console.WriteLine("Invalid keyword please try again");
            }
        }
    }
}



