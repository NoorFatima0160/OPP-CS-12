using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.UI
{
    class menuUI
    {

        public static int takeInput()
        {
            int options;
            Console.Clear();
            Console.WriteLine("1. add student");
            Console.WriteLine("2. Add degree program");
            Console.WriteLine("3. genrate merit");
            Console.WriteLine("4. View register students");
            Console.WriteLine("5. View students of a specific program");
            Console.WriteLine("6. Registered subjects for a specific program");
            Console.WriteLine("7. calculate fees of all students");
            Console.WriteLine("8. Exit");
            Console.WriteLine("Enter choice : ");
            options = int.Parse(Console.ReadLine());
            return options;
        }
    }
}
