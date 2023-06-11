using business_aplication_ver4.DL;
using business_aplication_ver4.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business_aplication_ver4.BL
{
    class userData
    {
        protected string userName;
        protected string password;
        public userData(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
        }
        public void setUserName(string userName)
        {
            bool decision;
            decision = userCRUD.IsValid(userName);
            if (decision == true)
            {
                this.userName = userName;
            }
            else
            {
                userUI.errorMenu();
            }
        }
        public string getUserName()
        {

            return this.userName;

        }
        public void setPassword(string password)
        {
          
                this.password = password;
            
        }
        public string getPassword()
        {

            return this.password;

        }
    }
}
