using business_aplication_ver4.DL;
using business_aplication_ver4.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business_aplication_ver4.BL
{
    class userSignIn : userData
    {
        public userSignIn(string userName, string password) : base(userName, password)
        {
           
        }
        public static string signIn(string name,string password)
        {
            string Role = userCRUD.getRoles(name, password);
            return Role;
        }

    }
}
