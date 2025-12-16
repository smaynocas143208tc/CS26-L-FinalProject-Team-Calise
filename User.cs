using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Core.Users
{
    public abstract class User
    {
        public int UserId { get; protected set; }
        public String UserName { get; protected set; }
        public string PasswordHash { get; protected set; }

        public abstract string role { get; }

        protected User(int userId, String username)
        {
            UserId = userId;
            UserName = username;
        }
    }
}
