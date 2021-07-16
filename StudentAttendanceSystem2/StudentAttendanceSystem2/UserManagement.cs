using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAS.BL
{
    public class UserManagement
    {
        public string userNameInput, userPasswordInput, newUserName, newUserPassword, newUserAddress;
        
        //The methods for creating an account and logging in to access the main menu.

        private string oldUserName = "user1";
        public string OldUsername
        {
            get
            {
                return oldUserName;
            }
        }
        private string oldUserPassword = "qwerty";
        public string OldUserPassword
        {
            get
            {
                return oldUserPassword;
            }
        }

        public void SignUp()
        {
            Console.WriteLine("Please Fill in the Informations Needed");
            Console.Write("Username: ");
            newUserName = Console.ReadLine();
            Console.Write("Password: ");
            newUserPassword = Console.ReadLine();     
            Console.WriteLine("Account has been created");
            
            MainMenu loginSuccess = new MainMenu();
            loginSuccess.ShowMainMenu();
        }
        public void LogIn()
        {
            Console.WriteLine("Please Enter Your Username & Password");
            Console.Write("Username: ");
            userNameInput = Console.ReadLine();
            Console.Write("Password: ");
            userPasswordInput = Console.ReadLine();

            if (oldUserName.Equals(userNameInput) && oldUserPassword.Equals(userPasswordInput))
            {
                Console.WriteLine("Welcome " + userNameInput);
                
                MainMenu loginSuccess = new MainMenu();
                loginSuccess.ShowMainMenu();
            }
            else if (userNameInput.Equals("") || userPasswordInput.Equals(""))
            {
                Console.WriteLine("Please Enter a Username or Password");
            }
            else
            {
                Console.WriteLine("Wrong Username or Password");
            }

        }
    }
}
