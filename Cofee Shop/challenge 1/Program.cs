using challenge_1.BL;
using challenge_1.DL;
using challenge_1.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            do
            {
                option = shopUI.mainMenu();
                if (option == 1)
                {
                    menu m1;
                    m1 = shopUI.addMenu();
                    cofeeShop.add_menu(m1);
                    shopUI.succeed();
                    shopUI.getch();

                }
                if (option == 2)
                {
                    string o1;
                    o1 = shopUI.addOrder();
                    cofeeShop.add_order(o1);
                    shopUI.succeed();
                    shopUI.getch();

                }
                if (option == 3)
                {
                    cofeeShop.fulfill_order();
                    shopUI.getch();

                }
                if (option == 4)
                {
                    cofeeShop.drinks();
                    shopUI.getch();

                }
                if (option == 5)
                {
                    cofeeShop.food();
                    shopUI.getch();

                }
                if (option == 6)
                {
                    string cheapest;
                    cheapest=cofeeShop.cheapest();
                    shopUI.printCheap(cheapest);
                    shopUI.getch();

                }
                if (option == 7)
                {
                    
                    cofeeShop.showOrder();
                    shopUI.getch();

                }
                if (option == 8)
                {
                    float bill;

                    bill=cofeeShop.amountOrder();
                    shopUI.printAmount(bill);
                    shopUI.getch();

                }
                if (option == 9)
                {
                    option = -1;

                }

            } while (option != -1);
        }
    }
}
