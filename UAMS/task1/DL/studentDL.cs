using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using task1.BL;

namespace task1.DL
{
    class studentDL
    {

        public static List<student> studentArray = new List<student>();
        public static void AddIntoStudentList(student s)
        {
            studentArray.Add(s);
        }

        public static student studentpresent(string name)
        {
            foreach (student s in studentArray)
            {
                if (name == s.name && s.regDegree != null)
                {
                    return s;
                }
            }
            return null;
        }


        public static List<student> sortStudentByMerit()
        {
            List<student> sortedList = new List<student>();
            foreach (student s in studentArray)
            {
                s.calculateMerit();
            }
            sortedList = studentArray.OrderByDescending(o => o.merit).ToList();
            return sortedList;
        }

        public static void giveAdmission(List<student> sortedList)
        {
            foreach (student s in sortedList)
            {
                foreach (Degree d in s.preference)
                {
                    if (d.seats > 0 && s.regDegree == null)
                    {
                        s.regDegree = d;
                        d.seats--;
                        break;
                    }
                }
            }
        }

        public static void storeIntoFile(string path, student s)
        {
            StreamWriter f = new StreamWriter(path, true);
            string degreeNames = "";
            for (int x = 0; x < s.preference.Count - 1; x++)
            {
                degreeNames = degreeNames + s.preference[x].degreeName + ";";

            }
            degreeNames = degreeNames + s.preference[s.preference.Count - 1].degreeName;
            f.WriteLine(s.name + "," + s.age + "," + s.fscMarks + "," + s.ecatMarks + ',' + degreeNames);
            f.Flush();
            f.Close();
        }

        public static bool readFromFile(string path)
        {
            StreamReader f = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string name = splittedRecord[0];
                    int age = int.Parse(splittedRecord[1]);
                    double fscMarks = float.Parse(splittedRecord[2]);
                    double ecatMarks = int.Parse(splittedRecord[3]);
                    string[] splittedRecordForPreference = splittedRecord[4].Split(';');
                    List<Degree> preference = new List<Degree>();
                    for (int x = 0; x < splittedRecordForPreference.Length; x++)
                    {
                        Degree d = DegreeDL.isDegreeExists(splittedRecordForPreference[x]);
                        if (d != null)
                        {
                            if (!(preference.Contains(d)))
                            {
                                preference.Add(d);
                            }
                        }
                      

                    }
                    student s = new student(name, age, fscMarks, ecatMarks, preference);
                    studentArray.Add(s);


                }
                f.Close();
                return true;
                
            }
            else
                return false;
        }

        
    }
}
