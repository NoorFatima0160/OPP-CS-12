using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ConsoleApp1.BL;
namespace ConsoleApp1
{
    class Program
    {
        static List<ship> shipArray = new List<ship>();
        static void Main(string[] args)
        {
            int option;
            do
            {
                option = menu();
                if (option == 1)
                {
                    ship s1;
                    s1 = takeInput();
                    shipArray.Add(s1);
                }
                if (option == 2)
                {
                    string serialNo;
                    Console.Write("Enter serial Number of ship : ");
                    serialNo = Console.ReadLine();
                   
                   
                    for(int i = 0; i < shipArray.Count; i++)
                    {
                        if (shipArray[i].shipNumber == serialNo)
                        {
                            Console.WriteLine("Ship is at " + shipArray[i].longituational.degree+"'" + shipArray[i].longituational.mins+"'" + shipArray[i].longituational.direction + " and " + shipArray[i].latituational.degree+"'" + shipArray[i].latituational.mins+"'" + shipArray[i].latituational.direction);
                        }
                        
                    }
                }

                if (option == 3)
                {
                    
                    Console.WriteLine("Enter ship longitute");
                    Console.Write("Enter longitute degree : ");
                    int longituational_degree = int.Parse(Console.ReadLine());
                    Console.Write("Enter longitute mins : ");
                    float longituational_mins = float.Parse(Console.ReadLine());
                    Console.Write("Enter longitute direction : ");
                    char longituational_direction = char.Parse(Console.ReadLine());
                    Console.WriteLine("Enter ship latiitute");
                    Console.Write("Enter latiitute degree : ");
                    int latituational_degree = int.Parse(Console.ReadLine());
                    Console.Write("Enter latiitute mins : ");
                    float latituational_mins = float.Parse(Console.ReadLine());
                    Console.Write("Enter latiitute direction : ");
                    char latituational_direction = char.Parse(Console.ReadLine());

                    int n = -1;
                    for (int i = 0; i < shipArray.Count; i++)
                    {
                        if (shipArray[i].longituational.degree == longituational_degree && shipArray[i].longituational.mins == longituational_mins && shipArray[i].longituational.direction == longituational_direction &&
                           shipArray[i].latituational.degree == latituational_degree && shipArray[i].latituational.mins == latituational_mins && shipArray[i].latituational.direction == latituational_direction)
                        {
                            n = i;
                        }

                    }
                    if (n != -1)
                    {
                        Console.WriteLine("Ship Number is : " + shipArray[n].shipNumber);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input " );
                    }
                }

                if (option == 4)
                {
                    string serialNum;
                    
                    
                    Console.Write("Enter serial Number of ship you want to change : ");
                    serialNum = Console.ReadLine();
                    for (int i = 0; i < shipArray.Count; i++)
                    {
                        if (shipArray[i].shipNumber == serialNum)
                        {
                            takeInputforShip(serialNum ,i);
                            
                            break;
                        }
                    }
                   

                }
                if (option == 5)
                {
                    option = -1;
                }
            }
            while (option != -1);
        }
        static public int menu()
        {
            int options;
           
            Console.WriteLine("1. Add ship");
            Console.WriteLine("2. View ship position");
            Console.WriteLine("3. View ship serial number");
            Console.WriteLine("4. Change ship position");
            Console.WriteLine("5. Exit");
            Console.Write("Enter option: ");
            options = int.Parse(Console.ReadLine());
            return options;
        }
        static public ship takeInput()
        {
          
            ship s2 = new ship();
            Console.Write("Enter ship number : ");
            s2.shipNumber = Console.ReadLine();
            Console.WriteLine("Enter ship longitute");
            Console.Write("Enter longitute degree : ");
            s2.longituational.degree = int.Parse(Console.ReadLine());
            Console.Write("Enter longitute mins : ");
            s2.longituational.mins = float.Parse(Console.ReadLine());
            Console.Write("Enter longitute direction : ");
            s2.longituational.direction = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter ship latiitute");
            Console.Write("Enter latiitute degree : ");
            s2.latituational.degree = int.Parse(Console.ReadLine());
            Console.Write("Enter latiitute mins : ");
            s2.latituational.mins = float.Parse(Console.ReadLine());
            Console.Write("Enter latiitute direction : ");
            s2.latituational.direction = char.Parse(Console.ReadLine());
            return s2;
        }

        static public void takeInputforShip(string num,int n)
        {

            ship s = new ship();
            shipArray[n].shipNumber = num;
            Console.WriteLine("Enter ship longitute");
            Console.Write("Enter longitute degree : ");
            shipArray[n].longituational.degree = int.Parse(Console.ReadLine());
            Console.Write("Enter longitute mins : ");
            shipArray[n].longituational.mins = float.Parse(Console.ReadLine());
            Console.Write("Enter longitute direction : ");
            shipArray[n].longituational.direction = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter ship latiitute");
            Console.Write("Enter latiitute degree : ");
            shipArray[n].latituational.degree = int.Parse(Console.ReadLine());
            Console.Write("Enter latiitute mins : ");
            shipArray[n].latituational.mins = float.Parse(Console.ReadLine());
            Console.Write("Enter latiitute direction : ");
            shipArray[n].latituational.direction = char.Parse(Console.ReadLine());
            
        }
    }
}
