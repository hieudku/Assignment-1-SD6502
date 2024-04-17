using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_SD6502
{
    class Student : Borrower
    {
        public override int MaxBorrowings { get { return 5; } }
        public override int MaxRenewals { get { return 1; } }
    }
}
