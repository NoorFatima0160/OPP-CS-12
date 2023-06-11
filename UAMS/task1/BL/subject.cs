using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.BL
{
    class subject
    {
        public string subCode;
        public string subType;
        public int creditHour;
        public int subjectFee;

        public subject(string subCode, string subType, int creditHour, int subFee)
        {
            this.subCode = subCode;
            this.subType = subType;
            this.creditHour = creditHour;
            this.subjectFee = subFee;

        }
    }
}
