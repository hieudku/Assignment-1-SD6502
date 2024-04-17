using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_SD6502
{
    class Program
    {
        static void Main(string[] args)
        {
            LibraryCatalog catalog = new LibraryCatalog();
            Staff staff = new Staff();
            Student student = new Student();

            // Adding library items
            catalog.AddItem(new LibraryItem("The Great Gatsby", Category.Book));
            catalog.AddItem(new LibraryItem("The Art of War", Category.Book));
            catalog.AddItem(new LibraryItem("Inception", Category.DigitalMedia));

            // Checking out items
            catalog.CheckOut("The Great Gatsby", staff);
            catalog.CheckOut("Inception", student);

            // Listing all items by category
            catalog.ListItemsByCategory(Category.Book);
            catalog.ListItemsByCategory(Category.DigitalMedia);

            // Listing borrowings
            catalog.ListBorrowings(staff);
            catalog.ListBorrowings(student);

            // Returning items
            catalog.CheckIn("The Great Gatsby");
            catalog.CheckIn("Inception");

            Console.ReadLine();
        }
    }

}

