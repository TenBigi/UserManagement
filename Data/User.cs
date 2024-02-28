using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagemet.Data
{
    public class User
    {
        private string userName;
        public string Name
        {
            get { return userName; }
            set { userName = value; }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }

        }
    }
}
