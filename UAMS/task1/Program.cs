using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task1.BL;
using task1.DL;
using task1.UI;

namespace task1
{
    class Program
    {
        private static object studentBL;

        static void Main(string[] args)
        {
            int option;
            string studentPath = "student.txt";
            string subjectPath = "subject.txt";
            string degreePath = "Degree.txt";
            if (subjectDL.readFromFile(subjectPath))
            {
                Console.WriteLine("subject Data loaded sucessfully");
            }
            if (DegreeDL.readFromFile(degreePath))
            {
                Console.WriteLine("degree Data loaded sucessfully");
            }
            if (studentDL.readFromFile(studentPath))
            {
                Console.WriteLine("subject Data loaded sucessfully");
            }
            do
            {
                student s1;
                option = menuUI.takeInput();

                if (option == 1)
                {
                    if (DegreeDL.programList.Count >= 0)
                    {
                        s1 = studentUI.takeInputForStudent();
                        studentDL.AddIntoStudentList(s1);
                    }

                }

                else if (option == 2)
                {
                    Degree d = DegreeUI.takeInputForDegree();
                    DegreeDL.addIntoDegreeList(d);
                }

                else if (option == 3)
                {
                    List<student> sortedList = new List<student>();
                    sortedList = studentDL.sortStudentByMerit();
                    studentDL.giveAdmission(sortedList);
                }
                else if (option == 4)
                {
                    studentUI.viewRegisteredStudent();
                }

                else if (option == 5)
                {
                    string degName;
                    Console.WriteLine("Enter Degree name");
                    degName = Console.ReadLine();
                    studentUI.viewStudentInDegree(degName);
                }
                else if (option == 6)
                {
                    Console.WriteLine("Enter student name");
                    string Name = Console.ReadLine();
                    student s = studentDL.studentpresent(Name);
                    if (s != null)
                    {
                        subjectUI.viewSubject(s);
                        subjectUI.registerSub(s);
                    }
                }
                else if (option == 7)
                {
                    studentUI.calculateForAll();
                }
                else if (option == 8)
                {
                    option = -1;
                }
            }
            while (option != -1);
        }
    }
}
