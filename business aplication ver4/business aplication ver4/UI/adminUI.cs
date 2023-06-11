using business_aplication_ver4.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business_aplication_ver4.UI
{
    class adminUI 
    {
        public static void displayUserOnScreen(string Name, string role)
        {

            Console.WriteLine(Name + "\t" + role);

        }
        public static item enterItem()
        {
            Console.Clear();
            userUI.boarder();
            int itemPrice;
            Console.Write("Enter name of item : ");
            string itemName = Console.ReadLine();
            Console.Write("Enter price of item : ");
            int check = int.Parse(Console.ReadLine());
            if (check > 0)
            {
                itemPrice = check;
                Console.Write("Enter number of item : ");
                int numOfItem = int.Parse(Console.ReadLine());
                item i1 = new item(itemName, itemPrice, numOfItem);
                return i1;
                userUI.success();
                userUI.getch();
            }
            else
            {
                userUI.errorMenu();
                return null;
            }
                       
        }
        public static string deletedItem()
        {
            Console.Write("Enter name of item you want to delete : ");
            string Find = Console.ReadLine();
            return Find;
        }
        public static string updated()
        {
            string itemFind;
            Console.Write("Enter name of item you want to update : ");
            itemFind = Console.ReadLine();
            return itemFind;
        }
        public static item updatedWith()
        {

            string updateItem;
            int updatePrice;
            int updateNum;

            Console.Write("Enter name of item you want to update with : ");
            updateItem = Console.ReadLine();
            Console.Write("Enter price of updated item : ");
            updatePrice = int.Parse(Console.ReadLine());
            Console.Write("Enter number of updated item : ");
            updateNum = int.Parse(Console.ReadLine());
            item i = new item(updateItem, updatePrice, updateNum);
            return i;
        }
    
    }
}
