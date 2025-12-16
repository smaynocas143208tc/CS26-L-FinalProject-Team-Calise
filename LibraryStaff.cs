using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Core.Users

{
    public class LibraryStaff : User
    {
        public override string role => "Staff";

        public LibraryStaff(int id, string username)
            : base(id, username) { }
    }
}
