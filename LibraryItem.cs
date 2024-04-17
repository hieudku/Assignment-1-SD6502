using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_SD6502
{
    enum Category
    {
        Book,
        DigitalMedia
    }

    class LibraryItem
    {
        public string Title { get; }
        public Category Category { get; }
        public bool Borrowed { get; private set; }
        public Borrower Borrower { get; private set; }
        public DateTime DueDate { get; private set; }

        public LibraryItem(string title, Category category)
        {
            Title = title;
            Category = category;
        }

        public void CheckOut(Borrower borrower)
        {
            Borrowed = true;
            Borrower = borrower;
            DueDate = DateTime.Now.AddDays(borrower.MaxBorrowings == 5 ? 90 : 365);
        }

        public void CheckIn()
        {
            Borrowed = false;
            Borrower = null;
            DueDate = default(DateTime);
        }

        public void Renew()
        {
            if (Borrower is Staff)
            {
                DueDate = DueDate.AddDays(365);
            }
            else
            {
                Console.WriteLine("Renewal not allowed for students.");
            }
        }

        public double CalculatePenalty()
        {
            if (Borrowed && DateTime.Now > DueDate)
            {
                int daysOverdue = (int)(DateTime.Now - DueDate).TotalDays;
                return daysOverdue * 5; // $5 per day penalty
            }
            return 0;
        }
    }
}
