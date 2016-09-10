using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("What is yor age?");
            int userAge = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("What month were you born in? (Please enter month in numerical form 1-12)");
            int birthMonth = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("What is your favorite ROYGBIV color? \nPlease enter \"Help\" for a list of colors");
            string color = Console.ReadLine();
            if (color.ToLower() == "help")
            {
                Console.WriteLine("R is for red" + "\n" + "O is for orange" + "\n" + "Y is for yellow" + "\n" + "G is for green" + "\n" + "B is for blue" + "\n" + "I is for indigo" + "\n" + "V is for violet");
                Console.WriteLine("Please enter your favorite color.");
                color = Console.ReadLine();
            }
            Console.WriteLine("\n");

            Console.WriteLine("How many siblings do you have?");
            int userSibling = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            
            if (userAge%2 == 0)
            {
                Console.WriteLine("You will retire in 90 years.");
            }
            else
            {
                Console.WriteLine("You will retire in 25 years.");
            }

            if (userSibling == 0)
            {
                Console.WriteLine("You will have a vacation home in Italy.");
            }
            else if (userSibling == 1)
            {
                Console.WriteLine("You will have a vacation home in Fiji.");
            }
            else if (userSibling == 2)
            {
                Console.WriteLine("You will have a vacation home in France.");
            }
            else if (userSibling == 3)
            {
                Console.WriteLine("You will have a vacation home in Long Island.");
            }
            else if (userSibling > 3)
            {
                Console.WriteLine("You will have a vacation home in the Bahamas.");
            }
            else if (userSibling <0)
            {
                Console.WriteLine("You will have a vacation home in Siberia.");
            }
            Console.ReadKey();
        }
    }
}
