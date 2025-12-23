using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Management_System.Enum;

namespace Library_Management_System.Members
{
    public class FacultyMember : Member
    {
        public int maxBooksAllowed;

        public FacultyMember(int maxBooks)
        {
            maxBooksAllowed = maxBooks;
        }

        public override int MaxBooksAllowed => maxBooksAllowed;

        public override int BorrowingDays => 14;

        public override decimal FineRatePerDay => 2m;
    }
}
