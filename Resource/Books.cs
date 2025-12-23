using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Resource
{
    public abstract class Books
    {
        public string AccessionNumber { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public string Publisher { get; set; }

        public abstract bool IsCirculating { get; }
    }
}
