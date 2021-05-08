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
       
        public static Dictionary<string, string> catChoices = new Dictionary<string, string>
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
        public static Dictionary<int, Product> shoppingCart = new Dictionary<int, Product>();
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
            string sbaRules = Console.ReadLine();
            actionMenu(sbaRules);
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

        public static void actionMenu(string input)
        {
            
            Console.WriteLine("Type A please");
            string vx = Console.ReadLine();
            if (vx == "A")
            {

                Console.WriteLine("Pick an item");
                string jimmy  = Console.ReadLine();
                printLine();
                Console.WriteLine($"Enter a Category");
                
                foreach(KeyValuePair<string,string> s in catChoices)
                {
                    Console.WriteLine($" {s.Key} {s.Value}");
                    
                }

                string sd = Console.ReadLine();

                Console.WriteLine("Enter a priority, low medium or high");
                
                foreach (KeyValuePair<string, string> s in priChoice)
                {
                    Console.WriteLine($" {s.Key} {s.Value}");

                }

                string av = Console.ReadLine();
                Product jimmyBag = new Product(jimmy, sd, av);
                shoppingCart.Add(1, jimmyBag);

                foreach (KeyValuePair<int, Product> svxs in shoppingCart)
                {
                    Console.WriteLine($ "Your cart: {svxs} ");
                }
            }
            Console.ReadKey();
           
        }
    }


    class Product
    {
        // Property with get/set
        public string Name { get; set; }
        public string Category { get; set; }
        public string Priority { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DatePurchased;
        //
        // public List<string> item() { };

        public Product(string _name, string _cat, string _pri)
        {
            this.Name = _name;
            this.Category = _cat;
            this.Priority = _pri; 
            // dateTime
            // dateTIme



        } 



    }
}
