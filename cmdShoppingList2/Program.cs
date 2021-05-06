using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandDotNet;

namespace cmdShoppingList2
{   
    //TO - DO
    // class product to return a List<>(name, cat, pri, date, purchaseStatus)
    // Action methods for each choice

    class Program
    {
        // Dictionaries for 
        public static Dictionary<string, string> menuChoice = new Dictionary<string, string>
        {
            {"A", "Add item"},
            {"R", "Remove an item"},
            {"E", "Edit an item"},
            {"P", "Mark item as purchased"},
            {"S", "Sort the list"},
            {"T", "Toggle display of purchased items"},
            {"Q", "Quit the program" }
        };
       
        public static Dictionary<string, string> catChoice = new Dictionary<string, string>
        {
            {"1", "Food"},
            {"2", "Clothing"},
            {"3", "Furniture"},
            {"4", "Household"},
            {"5", "Jewelry"},
            {"6", "Utilities"},
            {"7", "Tech"}
        };
        
        public static Dictionary<string, string> priChoice = new Dictionary<string, string>
        {
            {"L", "Low"},
            {"M", "Medium"},
            {"H", "High"}
        };

        // main list, mvp  
        public Dictionary<int, List<string>> shoppingCart = new Dictionary<int, List<string>>();
        // {id, { this.name, this.category, this.priority, this.dateAdded, this.purchaseStatus }}
        // shoppingCart.Add -> user does (name, category, priority), we do (id, dateAdded)
        // shoppingCart.Remove -> .removeAtIndex? remove via List[value].pop ? 
        // shoppingCart.Edit -> Basically like overriding name, cat, 
        // shoppingCart.Purchase -> Toggle basically?
        // shoppingCart.Quit? -> Can call actionMethod() for button choices, if Q return; 

        static void Main(string[] args)
        {
            //print ***, splash screen message
            printLine();
            //splash screen method
            splash();

            printLine();

            // ActionMenu() -> New items .Add
            // return dictionary shoppingCart<>
            // ActionMenu()
            printLine();
            
            // Ending thingy
            Console.ReadKey();
        }
        public static void splash()
        {
            string s = "Welcome to your personal Shopping Cart";
            // change c to the shoppingCart list 
            string c = $"You have {shoppingCart.Count} in your cart";

            //position before output
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.WriteLine(s);
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.WriteLine(c);
            Console.WriteLine();
        }

        public static void printLine()
        {
            int width = Console.WindowWidth;
            Console.WriteLine();
            Console.WriteLine(string.Concat(Enumerable.Repeat("*", width)));
            Console.WriteLine();
        }
    }

    class product
    {
        public List<string> item() { };


    }
}
