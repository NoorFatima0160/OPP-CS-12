using business_aplication_ver4.BL;
using business_aplication_ver4.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business_aplication_ver4.DL
{
    class userCRUD
    {
        static int index;
        static List<userData> userArray = new List<userData>();

        public static void addUser(userSignUp input)
        {
            userArray.Add(input);
        }

        public static void storeUser(userSignUp input, string Path)
        {
            if (File.Exists(Path))
            {
                StreamWriter file = new StreamWriter(Path, true);

                file.WriteLine(input.getUserName() + ',' + input.getPassword() + ',' + input.getRole());
                file.Flush();
                file.Close();

            }
            else
            {
                userUI.errorMenu();
            }

        }

        public static void loadData(string Path)
        {


            StreamReader file = new StreamReader(Path);
            string record;

            if (File.Exists(Path))
            {
                while ((record = file.ReadLine()) != null)
                {

                    string[] loadedData = record.Split(',');
                    string userNames = loadedData[0];
                    string userpassword = loadedData[1];
                    string roles = loadedData[2];
                    userSignUp u1 = new userSignUp(userNames, userpassword, roles);
                    userArray.Add(u1);


                }

                file.Close();
            }
            else
            {
                userUI.errorMenu();
            }


        }
        public static bool IsValid(string name)
        {

            if (userArray.Count == 0)
            {
                return true;
            }
            else if (userArray.Count != 0)
            {
                
                foreach(userData u in userArray)
                {
                    if (u.getUserName() == name)
                    {
                        return false;
                    }

                }
                return true;
            }
            else
                return false;
        }
        public static bool checkrole(string role)
        {
            if (role == "Admin" || role == "Client")
            {
                return true;
            }
            else
                return false;

        }


        public static string getRoles(string name , string Password)
        {
            foreach (userSignUp u in userArray)
            {
                if (u.getUserName() == name && u.getPassword() == Password)
                {
                    return u.getRole();
                }
               

            }
            return null;
            
        }

        public static void displayUser()
        {
            Console.Clear();
            userUI.boarder();
            foreach (userSignUp us in userArray)
            {
               
                    adminUI.displayUserOnScreen(us.getUserName(), us.getRole());
            }


        }
        public static void changePassword(string path)
        {

           
            Console.Clear();
            userUI.boarder();

            string passwords = userUI.inputFromUser();
            if (passwords != null)
            {
                {

                    userArray[index].setPassword(passwords)  ;
                    UpdatePasswordinFile(path);
                    userUI.success();
                }
            }
            else
            {
                userUI.errorMenu();
            }


        }
        public static bool checkIfValid(string name, string password)
        {
            for (int i = 0; i < userArray.Count; i++)
            {
                if (userArray[i].getUserName() == name && userArray[i].getPassword() == password)
                {
                    index = i;
                    return true;


                }
            }
            return false;

        }
        public static void UpdatePasswordinFile(string path)
        {
            if (File.Exists(path))
            {
                StreamWriter file4 = new StreamWriter(path);


                foreach (userSignUp user in userArray)
                {
                    file4.WriteLine(user.getUserName() + ',' + user.getPassword() + ',' + user.getRole());
                }
                file4.Flush();
                file4.Close();
            }
            else
                userUI.notExitMenu();
        }
    
    }


}

