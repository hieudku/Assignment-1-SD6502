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
            // Initialize the library catalog and borrowers
            var catalog = new LibraryCatalog();
            var staff = new Staff();
            var student = new Student();

            // Main menu loop
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nLibrary Management System");
                Console.WriteLine("1. Add Library Content");
                Console.WriteLine("2. Remove Library Content");
                Console.WriteLine("3. List All Contents");
                Console.WriteLine("4. List Contents by Category");
                Console.WriteLine("5. Borrow Item");
                Console.WriteLine("6. Return Item");
                Console.WriteLine("7. List Borrowings");
                Console.WriteLine("8. Calculate Penalties");
                Console.WriteLine("9. Exit");
                Console.Write("Select an option: ");

                // Process user input
                if (int.TryParse(Console.ReadLine(), out int option))
                {
                    switch (option)
                    {
                        case 1:
                            AddLibraryContent(catalog);
                            break;
                        case 2:
                            RemoveLibraryContent(catalog);
                            break;
                        case 3:
                            catalog.ListAllContents();
                            break;
                        case 4:
                            ListContentsByCategory(catalog);
                            break;
                        case 5:
                            BorrowItem(catalog, staff, student);
                            break;
                        case 6:
                            ReturnItem(catalog);
                            break;
                        case 7:
                            ListBorrowings(catalog, staff, student);
                            break;
                        case 8:
                            CalculatePenalties(catalog, staff, student);
                            break;
                        case 9:
                            exit = true;
                            Console.WriteLine("Exiting...");
                            break;
                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid option. Please try again.");
                }
            }
        }

        // Method to add library content
        static void AddLibraryContent(LibraryCatalog catalog)
        {
            Console.Write("Enter the title: ");
            string title = Console.ReadLine();

            Console.WriteLine("Select category:");
            Console.WriteLine("1. Book");
            Console.WriteLine("2. Article");
            Console.WriteLine("3. Digital Media");
            Console.Write("Enter your choice: ");
            if (int.TryParse(Console.ReadLine(), out int categoryChoice))
            {
                Category category = (Category)(categoryChoice - 1); // Adjust for zero-based enum
                catalog.AddItem(new LibraryItem { Title = title, Category = category });
                Console.WriteLine($"'{title}' added to the library.");
            }
            else
            {
                Console.WriteLine("Invalid category choice.");
            }
        }

        // Method to remove library content
        static void RemoveLibraryContent(LibraryCatalog catalog)
        {
            Console.Write("Enter the title to remove: ");
            string title = Console.ReadLine();
            if (catalog.RemoveItem(title))
            {
                Console.WriteLine($"'{title}' removed from the library.");
            }
            else
            {
                Console.WriteLine($"'{title}' not found in the library.");
            }
        }

        // Method to list library contents by category
        static void ListContentsByCategory(LibraryCatalog catalog)
        {
            Console.WriteLine("Select category:");
            Console.WriteLine("1. Book");
            Console.WriteLine("2. Article");
            Console.WriteLine("3. Digital Media");
            Console.Write("Enter your choice: ");
            if (int.TryParse(Console.ReadLine(), out int categoryChoice))
            {
                Category category = (Category)(categoryChoice - 1); // Adjust for zero-based enum
                catalog.ListItemsByCategory(category);
            }
            else
            {
                Console.WriteLine("Invalid category choice.");
            }
        }

        // Method to borrow an item
        static void BorrowItem(LibraryCatalog catalog, Staff staff, Student student)
        {
            Console.Write("Enter your ID (e.g., student1, staff1): ");
            string borrowerId = Console.ReadLine();

            Console.Write("Enter the title of the item to borrow: ");
            string title = Console.ReadLine();

            if (catalog.BorrowItem(title, borrowerId, staff, student))
            {
                Console.WriteLine($"'{title}' checked out by {borrowerId}.");
            }
            else
            {
                Console.WriteLine($"Unable to check out '{title}'.");
            }
        }

        // Method to return an item
        static void ReturnItem(LibraryCatalog catalog)
        {
            Console.Write("Enter the title of the item to return: ");
            string title = Console.ReadLine();

            if (catalog.ReturnItem(title))
            {
                Console.WriteLine($"'{title}' returned.");
            }
            else
            {
                Console.WriteLine($"Unable to return '{title}'.");
            }
        }

        // Method to list borrowings
        static void ListBorrowings(LibraryCatalog catalog, Staff staff, Student student)
        {
            Console.Write("Enter your ID (e.g., student1, staff1): ");
            string borrowerId = Console.ReadLine();

            catalog.ListBorrowings(borrowerId, staff, student);
        }

        // Method to calculate penalties
        static void CalculatePenalties(LibraryCatalog catalog, Staff staff, Student student)
        {
            Console.Write("Enter your ID (e.g., student1, staff1): ");
            string borrowerId = Console.ReadLine();

            double penalty = catalog.CalculatePenalties(borrowerId, staff, student);
            Console.WriteLine($"Total penalty for {borrowerId}: ${penalty}");
        }
    }
}


