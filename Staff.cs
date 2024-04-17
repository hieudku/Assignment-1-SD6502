using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_SD6502
{
    class Staff : Borrower
    {
        public override int MaxBorrowings { get { return int.MaxValue; } }
        public override int MaxRenewals { get { return int.MaxValue; } }
    }
}
