using business_aplication_ver4.BL;
using business_aplication_ver4.DL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business_aplication_ver4.UI
{
    class userUI
    {
        public static void boarder()
        {
            Console.Clear();
            Console.WriteLine("********************************************************");
            Console.WriteLine("***     Stationary Shop Management System            ***");
            Console.WriteLine("********************************************************");
        }
        public static void line()
        {
            Console.WriteLine("********************************************************");
        }
        public static int takeChoice()
        {
            int options;
            Console.Clear();
            boarder();
            Console.WriteLine("1. SignUp");
            Console.WriteLine("2. signIn");
            Console.WriteLine("3. eixt ");
            Console.Write("Enter choice : ");
            options = int.Parse(Console.ReadLine());
            return options;
        }
        public static userSignUp takeInput()  //sign up input
        {
            bool decision = false;
            bool check;

            Console.WriteLine("Enter userName :");
            string userNames = Console.ReadLine();

            decision = userCRUD.IsValid(userNames);
            if (decision == true)
            {
                Console.WriteLine("Enter password");
                string userpassword = Console.ReadLine();
                Console.WriteLine("Enter your role ");
                string role = Console.ReadLine();
                check = userCRUD.checkrole(role);
                if (check)
                {
                    if (userNames != null && userpassword != null && role != null)
                    {
                        userSignUp u1 = new userSignUp(userNames, userpassword, role);
                        return u1;
                    }
                    else
                    {

                        return null;
                    }
                }
                else
                {

                    return null;
                }

            }
            else
            {

                return null;

            }
        }

     
        public static userSignIn takeinputwithoutRole() //sign in input
        {
            string userName;
            string userpassword;
            Console.WriteLine("Enter username : ");
            userName = Console.ReadLine();
            Console.WriteLine("Enter password : ");
            userpassword = Console.ReadLine();
            if (userName != null && userpassword != null)
            {
                userSignIn u1 = new userSignIn(userName, userpassword);
                return u1;
            }
            else
            {
                return null;
            }
        }
        public static int adminMenu()
        {
            int choice;

            Console.Clear();
            boarder();
            Console.WriteLine("1. list of all user");
            Console.WriteLine("2. Enter new items");
            Console.WriteLine("3. Delete an item");
            Console.WriteLine("4. Update an item");
            Console.WriteLine("5. View all the item");
            Console.WriteLine("6. View most priced item");
            Console.WriteLine("7. Exist");
            Console.Write("Enter option : ");
            choice = int.Parse(Console.ReadLine());
            return choice;
        }
        public static int clientMenu()
        {
            int choice;

            Console.Clear();
            boarder();

            Console.WriteLine("1. View all the item");
            Console.WriteLine("2. Place your order");
            Console.WriteLine("3. Calculate bill");
            Console.WriteLine("4. View most priced item");
            Console.WriteLine("5. Change Password");
            Console.WriteLine("6. Exist");
            Console.Write("Enter option : ");
            choice = int.Parse(Console.ReadLine());
            return choice;
        }
        public static void errorMenu()
        {
            Console.WriteLine("invalid input");
            getch();
        }
        public static void getch()
        {
            Console.WriteLine("Press any key to return to main menu");
            Console.ReadLine();
        }
        public static void success()
        {


            Console.WriteLine("Process Succeed");

        }
        public static void heading()
        {
            Console.Write("items");
            Console.Write("\t");
            Console.Write("itemPrice");
            Console.Write("\t");
            Console.WriteLine("Number of items");
        }
        public static void displayItemrOnScreen(string name, int price, int number)
        {
            Console.Write(name);
            Console.Write("\t");
            Console.Write(price);
            Console.Write("\t\t");
            Console.WriteLine(number);
        }
        public static void notExitMenu()
        {
            Console.WriteLine("Not exist");
            
        }
        public static int billInput()
        {

            int num;

            Console.Write("Enter number of product you buy : ");
            num = int.Parse(Console.ReadLine());
            return num;

        }
        public static string nameInput(int x)
        {

            string iname;

            Console.Write("Enter name of " + x + " product you buy : ");
            iname = (Console.ReadLine());
            return iname;

        }
        public static int numberInput(int x)
        {

            int number;

            Console.Write("Enter number of " + x + "product you buy : ");
            number = int.Parse(Console.ReadLine());
            return number;

        }
        public static void displayBill(int bill)
        {

            Console.WriteLine("Your total bill is : " + bill);
        }
        public static void mostPriced(string name)
        {

            Console.WriteLine("The most priced item is : " + name);
        }
        public static string inputFromUser()
        {
            string clientName;
            string updateName;
            string clientPassword;
            string updatePassword;
            bool result;
            Console.WriteLine("Enter your userName : ");
            clientName = Console.ReadLine();
            Console.WriteLine("Enter your previous password: ");
            clientPassword = Console.ReadLine();
            result = userCRUD.checkIfValid(clientName, clientPassword);
            if (result == true)
            {
                Console.WriteLine("Enter new password : ");
                updatePassword = Console.ReadLine();
                return updatePassword;
            }
            else
            {
                return null;
            }
        }
    }
}
