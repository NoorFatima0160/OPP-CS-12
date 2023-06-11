using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task1.BL;

namespace task1.DL
{
    class subjectDL
    {
        public static List<subject> subjectList = new List<subject>();
        public static void addSubjectIntoList(subject s)
        {
            subjectList.Add(s);
        }
        public static void storeIntoFile(string path, subject s)
        {
            StreamWriter f = new StreamWriter(path, true);
            f.WriteLine(s.subCode + "," + s.subType + "," + s.creditHour + "," + s.subjectFee);
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
                    string code = splittedRecord[0];
                    string type = (splittedRecord[1]);
                    int creditHours = int.Parse(splittedRecord[2]);
                    int subjectFees = int.Parse(splittedRecord[3]);
                    subject s = new subject(code, type, creditHours , subjectFees);
                  
                    
                    addSubjectIntoList(s);

                }
                f.Close();
                return true;

            }
            else
            {
                return false;
            }

        }
        public static subject isSubjectExists(string type)
        {
            foreach(subject s in subjectList)
            {
                if(s.subType == type)
                {
                    return s;
                }
            }
            return null;
        }
    }
}
