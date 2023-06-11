using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.BL
{
    class student
    {
        public string name;
        public int age;
        public double fscMarks;
        public double ecatMarks;
        public double merit;
        public List<Degree> preference;
        public List<subject> regSubject;
        public Degree regDegree;

        public student(string name, int age, double fscMarks, double ecatMarks, List<Degree> preference)
        {
            this.name = name;
            this.age = age;
            this.fscMarks = fscMarks;
            this.ecatMarks = ecatMarks;
            this.preference = preference;
            regSubject = new List<subject>();


        }
        public void calculateMerit()
        {
            this.merit = (((fscMarks / 1100) * 0.45f) + ((ecatMarks / 400) * 0.45f)) * 100;
        }

        public bool regStudentSubject(subject s)
        {
            int stCH = getCreditHours();
            if (regDegree != null && regDegree.isSubExist(s) && stCH + s.creditHour <= 9)
            {
                regSubject.Add(s);
                return true;
            }
            else
            {
                return false;
            }
        }

        public int getCreditHours()
        {
            int count = 0;
            foreach (subject sub in regSubject)
            {
                count = count + sub.creditHour;
            }
            return count;
        }

        public float calculateFees()
        {
            float fees = 0;
            if (regDegree != null)
            {
                foreach (subject sub in regSubject)
                {
                    fees = fees + sub.creditHour;
                }

            }
            return fees;
        }
    }
}

