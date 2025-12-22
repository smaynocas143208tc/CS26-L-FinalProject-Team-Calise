using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Core
{
    public class LibrarianOrAdminAcc : User
    {
        public override string role => "Admin";

        public LibrarianOrAdminAcc(int id, string username)
            :base(id, username) { }

        public void GenerateReports() { }
        public void ConfigureSystem() { }
    }
}
