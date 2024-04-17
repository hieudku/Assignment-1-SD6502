using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_SD6502
{
    class Student : Borrower
    {
        public override int MaxBorrowings => 5; // Maximum borrowings for student = 5
        public override int MaxRenewals => 1; // Only one renewal after each borrowing expire
    }
}
