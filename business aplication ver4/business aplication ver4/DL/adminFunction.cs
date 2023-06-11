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
    class adminFunction
    {
        static List<item> itemArray = new List<item>();
        static List<string> elements = new List<string>();
        static List<int> number = new List<int>();
        static int decrease;
        static int counter;
        public static void adminfunctionality(string Path)
        {

            int choices;
            do
            {
                choices = userUI.adminMenu();
                if (choices == 1)
                {
                    
                    userCRUD.displayUser();
                    userUI.line();
                    userUI.getch();

                }
                if (choices == 2)
                {
                    item i=adminUI.enterItem();
                    addItem(i);
                    storeItemInFile(i, Path);
                    userUI.success();
                    userUI.getch();
                }
                if (choices == 3)
                {
                    DeleteItem(Path);
                    
                    userUI.line();
                    userUI.getch();

                }
                if (choices == 4)
                {
                    updateItem(Path);
                     userUI.line();
                    userUI.getch();

                }
                if (choices == 5)
                {
                    displaylistOfItem();
                    userUI.line();
                    userUI.getch();

                }
              
                if (choices == 6)
                {
                    displayMostPricedItem();
                    userUI.line();
                    userUI.getch();
                }
                if (choices == 7)
                {
                    choices = -1;
                }
            } while (choices != -1);
        }
        public static void addItem(item i)
        {
            itemArray.Add(i);
        }
        public static void displaylistOfItem()
        {

            Console.Clear();
            userUI.boarder();
            if (itemArray.Count > 0)
            {

                userUI.heading();
                foreach (item i in itemArray)
                {
                    userUI.displayItemrOnScreen(i.getItemName(), i.getItemPrice(), i.getItemNumber());

                }
            }
            else
            {
                userUI.notExitMenu();

            }

        }
        public static void storeItemInFile(item input, string Path)
        {

            StreamWriter file1 = new StreamWriter(Path, true);
            if (File.Exists(Path))
            {


                file1.WriteLine(input.getItemName() + ',' + input.getItemPrice() + ',' + input.getItemNumber());

                file1.Flush();
                file1.Close();
            }

        }
        public static void loadItemFromFile(string path)
        {


            StreamReader file2 = new StreamReader(path);
            string record;

            if (File.Exists(path))
            {
                while ((record = file2.ReadLine()) != null)
                {

                    string[] splittedData = record.Split(',');
                    string itemName = splittedData[0];
                    int itemPrice = int.Parse(splittedData[1]);
                    int numOfItem = int.Parse(splittedData[2]);
                    item i2 = new item(itemName, itemPrice, numOfItem);
                    itemArray.Add(i2);


                }

                file2.Close();
            }
            else
            {
                userUI.notExitMenu();
            }

        }
        public static void DeleteItem(string Path)
        {

            int n = -1;
            Console.Clear();
            userUI.boarder();
            string itemFind;
            itemFind = adminUI.deletedItem();
            for (int i = 0; i < itemArray.Count; i++)
            {
                if (itemArray[i].getItemName() == itemFind)
                {
                    n = i;
                }
            }
            if (n != -1)
            {

                itemArray.RemoveAt(n);
                deleteItemFromFile(Path);
                userUI.success();
            }

            else
            {
                userUI.notExitMenu();
            }

        }

        public static void deleteItemFromFile(string Path)
        {

            if (File.Exists(Path))
            {
                StreamWriter file3 = new StreamWriter(Path);


                for (int i = 0; i < itemArray.Count; i++)
                {
                    file3.WriteLine(itemArray[i].getItemName() + ',' + itemArray[i].getItemPrice() + ',' + itemArray[i].getItemNumber());

                }
                file3.Flush();
                file3.Close();
            }
            else
                userUI.notExitMenu();
                userUI.getch();
        }

        public static void updateItem(string Path)
        {
            int n = -1;
            bool checker=false;
            Console.Clear();
            userUI.boarder();
            string toFind = adminUI.updated();
            for (int i = 0; i < itemArray.Count; i++)
            {
                if (itemArray[i].getItemName() == toFind)
                {
                    checker=true;
                }
               
            }
            if (checker == true)
            { 
              item it = adminUI.updatedWith();

                if (itemArray.Count > 0)
                {
                    for (int i = 0; i < itemArray.Count; i++)
                    {
                        if (itemArray[i].getItemName() == toFind)
                        {
                            n = i;
                        }
                    }
                    if (n != -1)
                    {
                        itemArray[n].setItemName(it.getItemName());
                        itemArray[n].setItemPrice(it.getItemPrice());
                        itemArray[n].setItemNumber(it.getItemNumber());
                        UpdateIteminFile(Path);
                        userUI.success();
                    }
                }
               
            }
            else
            {
                userUI.notExitMenu();
            }
        }
        public static void UpdateIteminFile(string path)
        {
            if (File.Exists(path))
            {
                StreamWriter file4 = new StreamWriter(path);


                for (int i = 0; i < itemArray.Count; i++)
                {
                    file4.WriteLine(itemArray[i].getItemName() + ',' + itemArray[i].getItemPrice() + ',' + itemArray[i].getItemNumber());
                }
                file4.Flush();
                file4.Close();
            }
            else
                userUI.notExitMenu();
        }
        public static void order()
        {            
            string inpName;
            int inpNum;
            Console.Clear();
            userUI.boarder();
            counter = userUI.billInput();
            if (counter <= itemArray.Count)
            {
                bool verify=false;

                for (int i = 0; i < counter; i++)
                {
                    inpName = userUI.nameInput(i + 1);
                    verify = verifier(inpName);
                    if (verify == true)
                    { 
                      elements.Add(inpName);

                    }
                    if (verify == false)
                    {
                        userUI.notExitMenu();
                        userUI.getch();
                        order();
                    }
                    inpNum = userUI.numberInput(i + 1);
                    number.Add(inpNum);
                    itemArray[i].decreaseItemNumber(inpNum);
                }
        
            }
            else
            {
                userUI.notExitMenu();
            }

        }
        public static bool verifier(string Name)
        {
            bool check=false;
            for (int i = 0; i<itemArray.Count;i++)
            {
                if (itemArray[i].getItemName() == Name)
                {

                    check = true;
                    decrease = i;
                }
            }
            return check;
        }
         public static void calculateBill()
        {
            Console.Clear();
            userUI.boarder();
            int bill;
            int sum = 0;
            for (int i = 0; i < counter; i++)
            {
                for (int j = 0; j < itemArray.Count; j++)
                {
                    if (elements[i] == itemArray[j].getItemName())
                    {
                        bill = itemArray[j].getItemPrice();
                        bill = bill * number[i];
                        sum = sum + bill;
                    }
                }
            }
             userUI.displayBill(sum);

        }
        public static void displayMostPricedItem()
        {
            int n = -1;

            userUI.boarder();
            if (itemArray.Count > 0)
            {

                for (int i = 1; i < itemArray.Count; i++)
                {
                    if (itemArray[i].getItemPrice() > itemArray[i - 1].getItemPrice())
                    {
                        n = i;
                    }
                }

                userUI.mostPriced(itemArray[n].getItemName());
            }
            else
            {
                userUI.mostPriced(itemArray[0].getItemName());
            }


        }
        public static void UpdateNumOfItemInFile( string Path)
        {

            StreamWriter file1 = new StreamWriter(Path);
            if (File.Exists(Path))
            {

                foreach (item pro in itemArray)
                {
                    file1.WriteLine(pro.getItemName() + ',' + pro.getItemPrice() + ',' + pro.getItemNumber());
                }
                file1.Flush();
                file1.Close();
            }
              
            else
                userUI.notExitMenu();
        }


    }

}


