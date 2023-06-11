using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task1.BL;

namespace task1.UI
{
    class subjectUI
    {
        public static subject takeInputForSubject()
        {
            Console.WriteLine("Enter subject code : ");
            string code = (Console.ReadLine());
            Console.WriteLine("Enter subject type : ");
            string type = (Console.ReadLine());
            Console.WriteLine("Enter subject credit hours: ");
            int creditHours = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter subject credit hours fees : ");
            int subjectFees = int.Parse(Console.ReadLine());

            subject sub = new subject(code, type, creditHours, subjectFees);
            return sub;
        }

       public static void viewSubject(student s)
        {
            if (s.regDegree != null)
            {
                Console.WriteLine("Sub Code \t Sub Type ");
                foreach (subject sub in s.regDegree.subjects)
                {
                    Console.WriteLine(sub.subCode + "\t\t" + sub.subType);
                }
            }
        }

        public static void registerSub(student s)
        {
            Console.WriteLine("Enter how many subject you want to register");
            int count = int.Parse(Console.ReadLine());
            for (int x = 0; x < count; x++)
            {
                Console.WriteLine("Enter subject code : ");
                string code = Console.ReadLine();
                bool flag = false;
                foreach (subject sub in s.regDegree.subjects)
                {
                    if (code == sub.subCode && !(s.regSubject.Contains(sub)))
                    {
                        s.regStudentSubject(sub);
                        flag = true;
                        break;
                    }
                }
                if (flag == false)
                {
                    Console.WriteLine("Enter valid course ");
                    x--;
                }
            }
        }
    }
}
