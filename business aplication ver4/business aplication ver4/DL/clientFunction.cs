using business_aplication_ver4.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business_aplication_ver4.DL
{
    class clientFunction 
    {
        public static void clientfunctionality(string path , string Path)
        {

            int choices;
            do
            {
                choices = userUI.clientMenu();
              
              
            
                if (choices == 1)
                {
                    adminFunction.displaylistOfItem();
                    userUI.line();
                    userUI.getch();

                }
                if (choices == 2)
                {
                    adminFunction.order();
                    adminFunction.UpdateNumOfItemInFile(Path);
                    userUI.success();
                    userUI.line();
                    userUI.getch();
                }
                if (choices == 3)
                {

                    adminFunction.calculateBill();
                    userUI.line();
                    userUI.getch();
                }
                if (choices == 4)
                {
                    adminFunction.displayMostPricedItem();
                    userUI.line();
                    userUI.getch();
                }
                if (choices == 5)
                {
                    userCRUD.changePassword(path);
                    userUI.line();
                    userUI.getch();
                }
                if (choices == 6)
                {
                    choices = -1;
                }
            } while (choices != -1);
        }
    }
}
