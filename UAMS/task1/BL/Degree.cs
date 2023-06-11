using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.BL
{
    class Degree
    {
        public string degreeName;
        public int degreeDuration;
        public List<subject> subjects = new List<subject>();
        public int seats;

        public Degree(string degreeName, int degreeDuration, int seats)
        {
            this.degreeName = degreeName;
            this.degreeDuration = degreeDuration;
            this.seats = seats;

        }

        public int calculateCreditHours()
        {
            int count = 0;
            for (int x = 0; x < subjects.Count; x++)
            {
                count = count + subjects[x].creditHour;
            }
            return count;
        }

        public bool AddSubject(subject s)
        {
            int creditHours = calculateCreditHours();
            if (creditHours + s.creditHour <= 20)
            {
                subjects.Add(s);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isSubExist(subject sub)
        {
            foreach (subject storeS in subjects)
            {
                if (storeS.subCode == sub.subCode && storeS.subType == sub.subType)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
