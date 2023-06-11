using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business_aplication_ver4.BL
{
    class item
    {
        private string itemName;
        private int itemPrice;
        private int numOfItem;

        public item()
        {
           
        }
        public item(string itemName, int itemPrice, int numOfItem)
        {
            this.itemName = itemName;
            this.itemPrice = itemPrice;
            this.numOfItem = numOfItem;
        }

        public void setItemName(string name)
        {

            this.itemName= name;

        }
        public string getItemName()
        {

            return this.itemName;

        }

        public void setItemPrice(int price)
        {
            if (price > 0)
            {
                this.itemPrice = price;
            }
        }
        public int getItemPrice()
        {

            return this.itemPrice;

        }
        public void setItemNumber(int num)
        {
            if (num > 0)
            {
                this.numOfItem = num;
            }
        }
        public int getItemNumber()
        {

            return this.numOfItem;

        }
        public void decreaseItemNumber(int des)
        {
            if (des > 0)
            {
                this.numOfItem = this.numOfItem - des;
            }
        }
    }
}
