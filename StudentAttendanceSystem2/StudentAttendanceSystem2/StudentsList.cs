using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAS.BL
{
    public class StudentsList
    {
        //List of Student's Information

        public static void StudentsInfo()
        {
            string[] Students = {"Name: Student1 | Course: BSIT  | Student Number: 2021-00123-BN-0",
                                 "Name: Student2 | Course: BSCPE | Student Number: 2021-00123-BN-0",
                                 "Name: Student3 | Course: BSBA  | Student Number: 2021-00123-BN-0",
                                 "Name: Student4 | Course: BSIE  | Student Number: 2021-00123-BN-0",
                                 "Name: Student5 | Course: BSA   | Student Number: 2021-00123-BN-0"};


            foreach (string s in Students)
            {
                Console.WriteLine(s);
            }
        }
    } 
}
