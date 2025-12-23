using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Management_System.Enum;

namespace Library_Management_System.Members
{
    public class StudentMember : Member
    {
        private int maxBookAllowed;

        public StudentMember(int maxBooks)
        {
            maxBookAllowed = maxBooks;
        }

        public override int MaxBooksAllowed => maxBookAllowed;

        public override int BorrowingDays => 7;

        public override decimal FineRatePerDay => 5m;
    }
}
