using challenge_1.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge_1.UI
{
    class shopUI
    {

        public static int mainMenu()
        {
            int choice;
            Console.WriteLine("1. Add Menu");
            Console.WriteLine("2. Add order");
            Console.WriteLine("3. Fulfill order");
            Console.WriteLine("4. View drink menu");
            Console.WriteLine("5. View food menu");
            Console.WriteLine("6. View cheapest item in the menu");
            Console.WriteLine("7. View total order list");
            Console.WriteLine("8. Total payable bill");
            Console.WriteLine("9.Exit");
            Console.WriteLine("Enter your choice");
            choice = int.Parse(Console.ReadLine());
            return choice;

        }
        public static menu addMenu()
        {
            Console.WriteLine("Enter name of product");
            string name = (Console.ReadLine());
            Console.WriteLine("Enter type of product");
            string type = (Console.ReadLine());
            Console.WriteLine("Enter price of product");
            int price = int.Parse(Console.ReadLine());
            menu m1 = new menu(name, type, price);
            return m1;

        }
        public static string addOrder()
        {
            Console.WriteLine("Enter name of product you want to order");
            string o1 = (Console.ReadLine());
            return o1;
        }
        public static void printCheap(string cheap)
        {
            Console.WriteLine("The cheapest product int the menu is : " + cheap);


        }
        public static void printAmount(float bill)
        {
            Console.Write("Total payable bill is : " + bill);


        }
        public static void ready()
        {
            Console.WriteLine("The order is ready");
            
        
        }
        public static void showOrder(string i)
        {
            Console.WriteLine(i);


        }
        public static void getch()
        {
            line();
            Console.WriteLine("press any key to continue");
            Console.ReadLine();
            Console.Clear();


        }
        public static void notReady()
        {
            Console.WriteLine("no order is pending");


        }
        public static void showAllOrder(string i)
        {
            
            Console.WriteLine(i);


        }
        public static void drinks(string i)
        {
            
            Console.WriteLine(i);


        }
        public static void heading()
        {
            Console.WriteLine("products are");
           


        }
        public static void succeed()
        {
            Console.WriteLine("process suceed");


        }
        public static void line()
        {
            Console.WriteLine("-----------------------");
        }

    }
}
