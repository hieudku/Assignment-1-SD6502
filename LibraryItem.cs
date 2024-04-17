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
        Article,
        DigitalMedia
    }

    class LibraryItem
    {
        public string Title { get; set; }
        public Category Category { get; set; }
        public bool Borrowed { get; set; }
        public Borrower Borrower { get; set; }
        public DateTime DueDate { get; set; }

        public void CheckOut(Borrower borrower)
        {
            Borrowed = true;
            Borrower = borrower;
            DueDate = DateTime.Now.AddDays(borrower is Staff ? 365 : 90); // Staff can keep for a calendar year, students for 90 days
        }

        public void CheckIn()
        {
            Borrowed = false;
            Borrower = null;
        }

        public virtual void Renew()
        {
            // Implement renewal logic for staff
            if (Borrower is Staff)
            {
                DueDate = DateTime.Now.AddDays(365);
                Console.WriteLine($"Item '{Title}' renewed for another year.");
            }
            else
            {
                Console.WriteLine($"Renewal not allowed for students.");
            }
        }

        public virtual double CalculatePenalty()
        {
            if (Borrowed && DateTime.Now > DueDate)
            {
                int daysOverdue = (int)(DateTime.Now - DueDate).TotalDays;
                return daysOverdue * 5; // $5 per day penalty
            }
            return 0.0;
        }
    }
}
