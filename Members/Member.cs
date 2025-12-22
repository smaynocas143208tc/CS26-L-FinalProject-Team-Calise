using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Management_System.Enum;

namespace Library_Management_System.Members
{
    public abstract class Member
    {
        public int MemberID { get; set; }
        public string FullName { get; set; }
        public MemberStatus Status { get; set; }
        public DateTime RegistrationDate { get; set; }

        public abstract int MaxBooksAllowed { get; }
        public abstract int BorrowingDays { get;  }
        public abstract decimal FineRatePerDay { get; }

        public bool IsEligibleToBorrow(int currentBorrowed)
        {
            return Status == MemberStatus.Active && currentBorrowed < MaxBooksAllowed;
        }
    }
}
