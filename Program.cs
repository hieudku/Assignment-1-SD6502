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
            string staffOrStudent;
            string userName;
            Library lib = new Library();
            


            do
            {
                do
                {
                    Console.WriteLine("Are you a staff or student? (1/2)");
                    staffOrStudent = Convert.ToString(Console.ReadLine());

                    if (staffOrStudent == "1")
                    {
                        Staffs staff = new Staffs();
                        break;
                    }
                    else if (staffOrStudent == "2")
                    {
                        Students student = new Students(userName);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid selection (1/2)");
                    }
                } while (staffOrStudent != "1" || staffOrStudent != "2" || staffOrStudent == "");


                Console.WriteLine("Please enter your name: ");
                userName = Console.ReadLine();

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
                    Category category = new Category();
                    category.DisplayCategory();
                    lib.DisplayContents();
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
        
        List<string> contentList = new List<string>();
        bool avalability;


        public Library()
        {

        }

        public bool Avalability { get => avalability; set => avalability = value; }
        public void DisplayCategory()
        {

            var categories = Category.GetCategories();
            foreach (var category in categories)
            {
                Console.WriteLine($"***{ category.Name}");
            }
        }

    public void DisplayContents()
        {
            int num = 1;
            foreach (string item in contentList)
            {
                Console.WriteLine($". {item}");
                num++;
            }
        }
        public void AddItem(string itemName)
        {
            contentList.Add(itemName);

        }
    }
    class Category : Library
    {
        public string Name { get; set; }
        private static List<Category> categoryList = new List<Category>();

        static Category()
        {
            categoryList.Add(new Category { Name = "Books" });
            categoryList.Add(new Category { Name = "Articles" });
            categoryList.Add(new Category { Name = "Journal" });
            categoryList.Add(new Category { Name = "Digital Media" });
        }
        public static List<Category> GetCategories()
        {
            return categoryList;
        }
    }
    class Content : Category
    {
        List<string> contentList = new List<string>();
    }

    class Staffs
    {
        string staffName;
        public Staffs(string staffName)
        {
            this.StaffName = staffName;
        }
        
public string StaffName { get => staffName; set => staffName = value; }
    }
    }

    class Students
    {
        string studentName;
    }
}

