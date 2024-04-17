using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_SD6502
{
    class LibraryCatalog
    {
        private List<LibraryItem> Items = new List<LibraryItem>();

        public void AddItem(LibraryItem item)
        {
            Items.Add(item);
        }

        public bool RemoveItem(string title)
        {
            LibraryItem itemToRemove = Items.Find(item => item.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (itemToRemove != null)
            {
                Items.Remove(itemToRemove);
                Console.WriteLine($"'{title}' removed from the library.");
                return true; // Item successfully removed
            }
            else
            {
                Console.WriteLine($"'{title}' not found in the library.");
                return false; // Item not found, unable to remove
            }
        }

        public void ListItemsByCategory(Category category)
        {
            Console.WriteLine($"Listing {category} items:");
            foreach (var item in Items)
            {
                if (item.Category == category)
                    Console.WriteLine($"{item.Title} ({(item.Borrowed ? "Borrowed" : "Available")})");
            }
        }

        public void ListAllContents()
        {
            Console.WriteLine("Listing all contents:");
            foreach (var item in Items)
            {
                Console.WriteLine($"{item.Title} ({(item.Borrowed ? "Borrowed" : "Available")})");
            }
        }

        public void ListBorrowings(string borrowerId, Staff staff, Student student)
        {
            Borrower borrower = borrowerId.StartsWith("staff", StringComparison.OrdinalIgnoreCase) ? (Borrower)staff : student;
            Console.WriteLine($"Borrowings for {borrower.GetType().Name}:");
            foreach (var item in Items)
            {
                if (item.Borrower == borrower)
                    Console.WriteLine($"{item.Title} (Due: {item.DueDate})");
            }
        }

        public bool BorrowItem(string title, string borrowerId, Staff staff, Student student)
        {
            LibraryItem item = Items.Find(i => i.Title.Equals(title, StringComparison.OrdinalIgnoreCase) && !i.Borrowed);
            if (item != null)
            {
                Borrower borrower = borrowerId.StartsWith("staff", StringComparison.OrdinalIgnoreCase) ? (Borrower)staff : student;
                item.CheckOut(borrower);
                return true;
            }
            return false;
        }

        public bool ReturnItem(string title)
        {
            LibraryItem item = Items.Find(i => i.Title.Equals(title, StringComparison.OrdinalIgnoreCase) && i.Borrowed);
            if (item != null)
            {
                item.CheckIn();
                return true;
            }
            return false;
        }

        public double CalculatePenalties(string borrowerId, Staff staff, Student student)
        {
            double totalPenalty = 0;
            Borrower borrower = borrowerId.StartsWith("staff", StringComparison.OrdinalIgnoreCase) ? (Borrower)staff : student;

            foreach (var item in Items)
            {
                if (item.Borrowed && item.Borrower == borrower)
                {
                    totalPenalty += item.CalculatePenalty();
                }
            }

            return totalPenalty;
        }
    }
}

