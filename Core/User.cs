using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Core
{
    public abstract class User
    {
        public int UserID { get; protected set; }
        public string UserName { get; protected set; }
        public string PasswordHash { get; protected set; }

        public abstract string role { get;  }

        protected User(int userid, string username)
        {
            UserID = userid;
            UserName = username;
        }
    }
}
