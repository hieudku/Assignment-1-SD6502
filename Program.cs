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


            do
            {
                Console.WriteLine("Welcome to the online library. Select:");
                Console.WriteLine("1. Display lists of items");
                Console.WriteLine("2. Borrow items");
                Console.WriteLine("3. Return items");




                Console.WriteLine("Would you like to make additional request? (Y/N)");
                userContinue = Convert.ToChar(Console.ReadLine());
                userContinue = Char.ToUpper(userContinue);

            } while (userContinue == 'Y');

        }
    }
    class Library
    {
        string itemCategory;
        string itemName;
        bool avalability;

        public Library()
        {

        }

        public string ItemName { get => itemName;}
        public string ItemCategory { get => itemCategory;}
        public bool Avalability { get => avalability; set => avalability = value; }

        public void Borrow()
        {

        }
    }

    class Renewal : Library
    {
        
    }

    class Staffs
    {

    }

    class Students
    {

    }
}
