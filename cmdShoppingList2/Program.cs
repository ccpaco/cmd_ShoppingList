using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandDotNet;

namespace cmdShoppingList2
{
    class Program
    {
       
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
        
        static void Main(string[] args)
        {
            printLine();

            Console.WriteLine(" Welcome to your doom");

            printLine();

            foreach (KeyValuePair<string, string> i in menuChoice)
            {
                Console.WriteLine(" " + i);
            }

            printLine();
            
            Console.ReadKey();
        }

        public static void printLine()
        {
            int width = Console.WindowWidth;
            Console.WriteLine();
            Console.WriteLine(string.Concat(Enumerable.Repeat("*", width)));
            Console.WriteLine();
        }
    }
}
