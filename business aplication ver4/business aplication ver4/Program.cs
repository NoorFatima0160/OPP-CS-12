using business_aplication_ver4.BL;
using business_aplication_ver4.DL;
using business_aplication_ver4.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business_aplication_ver4
{
    class Program
    {
        static void Main()
        {
            {


                string path = "users.txt";
                string Path = "products.txt";
                int option;
                userCRUD.loadData(path);
                adminFunction.loadItemFromFile(Path);
                

                do
                {
                    Console.Clear();
                    userUI.boarder();

                    option = userUI.takeChoice();

                    if (option == 1)
                    {

                        userSignUp myUser = userUI.takeInput();

                        if (myUser != null)
                        {
                            userCRUD.addUser(myUser);
                            userCRUD.storeUser(myUser,path);
                            userUI.success();
                            userUI.getch();
                        }
                        else
                        {
                            userUI.errorMenu();
                        }

                        continue;



                    }
                    else if (option == 2)
                    {
                        userSignIn myUser = userUI.takeinputwithoutRole();
                        if (myUser != null)
                        {
                            string userRole = userSignIn.signIn(myUser.getUserName(), myUser.getPassword());

                            if (userRole == null)
                            {
                                userUI.errorMenu();
                            }
                            else if (userRole == "Admin")
                            {

                                adminFunction.adminfunctionality(Path);
                            }
                            else if (userRole == "Client")
                            {
                                clientFunction.clientfunctionality(path,Path);

                            }
                            else
                            {
                                Console.WriteLine("invalid input");
                            }
                        }
                        else
                        {

                            userUI.errorMenu();
                        }
                        continue;
                    }
                    else if (option == 3)
                    {

                        option = -1;
                    }
                    else
                    {
                        userUI.errorMenu();
                    }

                } while (option != -1);

            }
        }   }
}
