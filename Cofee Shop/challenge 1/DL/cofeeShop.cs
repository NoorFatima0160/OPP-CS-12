using challenge_1.BL;
using challenge_1.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge_1.DL
{
    class cofeeShop
    {

        public static List<menu> menuList = new List<menu>();
        public  static List<string> orders = new List<string>();
        public string shopName;

        public cofeeShop(string shopName)
        {
            this.shopName = shopName;
        }

        public static void add_menu(menu m)
        {
            menuList.Add(m);
        }
        public static void add_order(string order)
        {
            orders.Add(order);
        }

        public static void fulfill_order()
        {
            if(orders != null)
            {
                shopUI.showOrder(orders[0]);
                shopUI.ready();
                orders.RemoveAt(0);
                

            }
            else
            {
                shopUI.notReady();
               
            }
        }

        public static void showOrder()
        {
            shopUI.heading();
            foreach(string o in orders)
            {
                shopUI.showAllOrder(o);
            }
            
        }


        public static float amountOrder()
        {
            float amount = 0.0f;
            foreach (string o in orders)
            {
                for(int i=0; i < menuList.Count; i++)
                {
                    if (o == menuList[i].name)
                    {
                        amount = amount + menuList[i].price;
                    }
                }
            }
            return amount;
        }
        public static string cheapest()
        {
            int cheap = menuList[0].price;
            int n = 0;
            if (menuList.Count > 0) 
            { 
            for (int i = 1; i < menuList.Count; i++)
            {
                if (menuList[i].price < cheap)
                {
                    cheap = menuList[i].price;
                    n = i; 
                }
            }
                return menuList[n].name;
            }

            else
                return menuList[0].name;
        }

        public static void drinks()
        {
            shopUI.heading();
            for (int i = 0; i < menuList.Count; i++)
            {
                if ( menuList[i].type == "drink")
                {
                    shopUI.drinks(menuList[i].name);
                }
            }
            
        }

        public static void food()
        {
            shopUI.heading();
            for (int i = 0; i < menuList.Count; i++)
            {
                if (menuList[i].type == "food")
                {
                    shopUI.drinks(menuList[i].name);
                }
            }
            shopUI.getch();
        }
    }
}
