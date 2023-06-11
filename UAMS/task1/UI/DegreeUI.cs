using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task1.BL;
using task1.DL;

namespace task1.UI
{
    class DegreeUI
    {
       

        public static Degree takeInputForDegree()
        {
            Console.WriteLine("Enter name of degree : ");
            string degreename = (Console.ReadLine());
            Console.WriteLine("Enter degree durration : ");
            int degreedurration = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter seats for degree: ");
            int degreeseats = int.Parse(Console.ReadLine());

            Degree degProg = new Degree(degreename, degreedurration, degreeseats);
            Console.WriteLine("Enter number of subjects: ");
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                degProg.AddSubject(subjectUI.takeInputForSubject());
            }
            return degProg;
        }

        public static void viewDegreeProgram()
        {
            foreach (Degree dp in DegreeDL.programList)
            {
                Console.WriteLine(dp.degreeName);
            }
        }
    }
}
