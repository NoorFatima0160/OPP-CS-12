using business_aplication_ver4.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business_aplication_ver4.BL
{
    class userSignUp : userData
    {
        private string role;
        public userSignUp(string userName , string password , string role) : base(userName, password)
        {
            this.role = role;
        }

        public void setRole(string role)
        {
            if(role=="Admin" || role == "Client")
            {
                this.role = role;
            }
            else
            {
                userUI.errorMenu();
            }
        }
        public string getRole()
        {
            
               return this.role;
            
        }
    }
}
