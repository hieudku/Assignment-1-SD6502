using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_SD6502
{
    abstract class Borrower
    {
        public abstract int MaxBorrowings { get; }
        public abstract int MaxRenewals { get; }
    }
}
