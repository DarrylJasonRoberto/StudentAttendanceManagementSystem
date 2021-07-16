using System;
using SAS.BL;

namespace SAS.UI
{
    class Program
    {       
        public static void Main(string[] args)
        {
            string optionSelected;

            //The starting screen where the user will create an account or login with an existing account.

            Console.WriteLine("<><><><><>|----------------------------------|<><><><><>");
            Console.WriteLine("<><><><><>|~Do you have an existing account~~|<><><><><>");
            Console.WriteLine("<><><><><>|~Press Y/y if Yes or N/n if None~~|<><><><><>");
            Console.WriteLine("<><><><><>|----------------------------------|<><><><><>");

            optionSelected = Console.ReadLine().ToLower();
            
            if (optionSelected.Equals("y"))
            {
                UserManagement login = new UserManagement();
                login.LogIn();              
            }
            else if (optionSelected.Equals("n"))
            {
                UserManagement signin = new UserManagement();
                signin.SignUp();                       
            }
            else
            {
                Console.WriteLine("Invalid keyword please try again");
            }

        }
    }
    
}
