using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task1.BL;
using task1.DL;

namespace task1.UI
{
    class studentUI
    {
        

        public static void viewRegisteredStudent()
        {
            Console.WriteLine("Name\tFSC\tEcat\tAge ");
            foreach (student s in studentDL.studentArray)
            {
                if (s.regDegree != null)
                {
                    Console.WriteLine(s.name + "\t" + s.fscMarks + "\t" + s.ecatMarks + "\t" + s.age);
                }
            }
        }


        public static void printStudents()
        {
            Console.WriteLine("press any key to continue ");
            Console.ReadLine();
            Console.Clear();
        }

        public static void viewStudentInDegree(string degName)
        {
            Console.WriteLine("Name\tFSC\tEcat\tAge ");
            foreach (student s in studentDL.studentArray)
            {
                if (s.regDegree != null)
                {
                    if (degName == s.regDegree.degreeName)
                    {
                        Console.WriteLine(s.name + "\t" + s.fscMarks + "\t" + s.ecatMarks + "\t" + s.age);


                    }
                }
            }
        }

        static public student takeInputForStudent()
        {

            List<Degree> preference = new List<Degree>();
            Console.WriteLine("Enter name of student : ");
            string name = (Console.ReadLine());
            Console.WriteLine("Enter age : ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter fsc marks : ");
            float fscM = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter ecat marks : ");
            float ecatM = float.Parse(Console.ReadLine());
            Console.WriteLine("available Degree program : ");
            DegreeUI.viewDegreeProgram();


            for (int i = 0; i < 4; i++)
            {
                Console.Write("Enter name of " + (i + 1) + " preference : ");
                string pref = Console.ReadLine();
                bool flag = false;
                foreach (Degree dp in DegreeDL.programList)
                {
                    if (pref == dp.degreeName && !(preference.Contains(dp)))
                    {
                        preference.Add(dp);
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    Console.WriteLine("Enter validdegree program : ");
                    i--;
                }
            }

            student s = new student(name, age, fscM, ecatM, preference);
            return s;

        }

        public static void calculateForAll()
        {
            foreach (student s in studentDL.studentArray)
            {
                if (s.regDegree != null)
                {
                    Console.WriteLine(s.name + "has" + s.calculateFees() + "fees");
                }
            }
        }

    }
}
