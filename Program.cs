using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_SD6502
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char userContinue;
            char userSelect;
            Library lib = new Library();


            do
            {
                Console.WriteLine("Welcome to the online library. Select:");
                Console.WriteLine("1. Display lists of contents by categories");
                Console.WriteLine("2. Borrow items");
                Console.WriteLine("3. Return items");
                Console.WriteLine("4. Add an item");
                Console.WriteLine("5. Remove an item");

                userSelect = Convert.ToChar(Console.ReadLine());

                if (userSelect == '1')
                {
                    Console.WriteLine("lists of contents by categories:");
                    lib.DisplayCategory();
                }
                else if (userSelect == '4')
                {
                    Console.WriteLine("Please enter the item's category: ");
                    lib.AddItem(Console.ReadLine());

                    Console.WriteLine("Please enter the item's name");
                }

                Console.WriteLine("Would you like to make additional request? (Y/N)");
                userContinue = Convert.ToChar(Console.ReadLine());
                userContinue = Char.ToUpper(userContinue);

            } while (userContinue == 'Y');

        }
    }
    class Library
    {
        List<string> itemCategory = new List<string> {"Books", "Articles", "Digital", "Journal" };
        List<string> itemName = new List<string>();
        bool avalability;


        public Library()
        {

        }

        public bool Avalability { get => avalability; set => avalability = value; }
        public List<string> ItemCategory { get => itemCategory; set => itemCategory = value; }
        public List<string> ItemName { get => itemName; set => itemName = value; }

        public void DisplayCategory()
        {
            int num = 1;
            foreach (string category in itemCategory)
            {
                Console.WriteLine($"{num}. { category}");
                num++;
            }
        }
        public void AddItem(string itemName)
        {
            itemCategory.Add(itemName);

        }
    }

    class Renewal : Library
    {
        
    }

    class Staffs
    {
        string staffName;
    }

    class Students
    {
        string studentName;
    }
}
