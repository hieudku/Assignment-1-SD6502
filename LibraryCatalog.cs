using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_SD6502
{
    class LibraryCatalog
    {
        private List<LibraryItem> Items { get; }

        public LibraryCatalog()
        {
            Items = new List<LibraryItem>();
        }

        public void AddItem(LibraryItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(LibraryItem item)
        {
            Items.Remove(item);
        }

        public void ListItemsByCategory(Category category)
        {
            Console.WriteLine($"Items in {category} category:");
            foreach (var item in Items)
            {
                if (item.Category == category)
                {
                    Console.WriteLine($"{item.Title}");
                }
            }
        }

        public void ListBorrowings(Borrower borrower)
        {
            Console.WriteLine($"Borrowings for {(borrower is Staff ? "Staff" : "Student")}:");

            foreach (var item in Items)
            {
                if (item.Borrowed && item.Borrower == borrower)
                {
                    Console.WriteLine($"{item.Title} (Due Date: {item.DueDate})");
                }
            }
        }

        public void CheckOut(string title, Borrower borrower)
        {
            LibraryItem item = Items.Find(i => i.Title == title);
            if (item != null && !item.Borrowed)
            {
                item.CheckOut(borrower);
                Console.WriteLine($"'{title}' checked out by {(borrower is Staff ? "Staff" : "Student")}.");
            }
            else
            {
                Console.WriteLine($"'{title}' is either not available or already checked out.");
            }
        }

        public void CheckIn(string title)
        {
            LibraryItem item = Items.Find(i => i.Title == title);
            if (item != null && item.Borrowed)
            {
                item.CheckIn();
                Console.WriteLine($"'{title}' checked in.");
            }
            else
            {
                Console.WriteLine($"'{title}' is not checked out or not found.");
            }
        }
    }
}

