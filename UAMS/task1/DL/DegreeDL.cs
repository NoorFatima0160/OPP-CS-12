using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task1.BL;

namespace task1.DL
{
    class DegreeDL
    {
        public static List<Degree> programList = new List<Degree>();
        public static void addIntoDegreeList(Degree d)
        {
            programList.Add(d);
        }

        public static Degree isDegreeList(string degreeName)
        {
            foreach(Degree d in programList)
            {
                if(d.degreeName == degreeName)
                {
                    return d;
                }
            }
            return null;
        }

        public static void storeIntoFile(string path , Degree d)
        {
            StreamWriter f = new StreamWriter(path, true);
            string SubjectNames = "";
            for(int x=0; x <d.subjects.Count - 1; x++)
            {
                SubjectNames = SubjectNames + d.subjects[x].subType + ";";
                
            }
            SubjectNames = SubjectNames + d.subjects[d.subjects.Count - 1].subType;
            f.WriteLine(d.degreeName + "," +d.degreeDuration + "," + d.seats + "," + SubjectNames);
            f.Flush();
            f.Close();
        }
        public static bool readFromFile(string path)
        {
            StreamReader f = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string degreeName = splittedRecord[0];
                    int degreeDurration = int.Parse(splittedRecord[1]);
                    int seats = int.Parse(splittedRecord[2]);
                    string[] splittedRecordForSubject = splittedRecord[3].Split(';');
                    Degree d = new Degree(degreeName, degreeDurration, seats);
                    for (int x = 0; x < splittedRecordForSubject.Length; x++)
                    {
                        subject s = subjectDL.isSubjectExists(splittedRecordForSubject[x]);
                        if (s != null)
                        {
                            d.AddSubject(s);
                        }
                        
                    }
                    addIntoDegreeList(d);
                    
                    }
                f.Close();
                return true;
               
                }
            else
            {
                return false;
            }
        
        }
        public static Degree isDegreeExists(string name)
        {
            foreach (Degree s in programList)
            {
                if (s.degreeName == name)
                {
                    return s;
                }
            }
            return null;
        }
    }
}
