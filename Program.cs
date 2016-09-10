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
                Console.WriteLine("will retire in 90 years");
            }
            else
            {
                Console.WriteLine("will retire in 25 years");
            }

            if (userSibling == 0)
            {
                Console.WriteLine("a vacation home in Italy");
            }
            else if (userSibling == 1)
            {
                Console.WriteLine("a vacation home in Fiji");
            }
            else if (userSibling == 2)
            {
                Console.WriteLine("a vacation home in France");
            }
            else if (userSibling == 3)
            {
                Console.WriteLine("a vacation home in Long Island");
            }
            else if (userSibling > 3)
            {
                Console.WriteLine("a vacation home in the Bahamas");
            }
            else if (userSibling <0)
            {
                Console.WriteLine("a vacation home in Siberia");
            }

            if (color.ToLower() == "red" || color.ToLower() == "r")
            {
                Console.WriteLine("a horse.");
            }
            else if (color.ToLower() == "orange" || color.ToLower() == "o")
            {
                Console.WriteLine("a helicopter.");
            }
            else if (color.ToLower() == "yellow" || color.ToLower() == "y")
            {
                Console.WriteLine("a donkey.");
            }
            else if (color.ToLower() == "green" || color.ToLower() == "g")
            {
                Console.WriteLine("a car.");
            }
            else if (color.ToLower() == "blue" || color.ToLower() == "b")
            {
                Console.WriteLine("a motorcycle.");
            }
            else if (color.ToLower() == "indigo" || color.ToLower() == "i")
            {
                Console.WriteLine("a boat.");
            }
            else if (color.ToLower() == "violet" || color.ToLower() == "v")
            {
                Console.WriteLine("a plane.");
            }
            Console.ReadKey();
        }
    }
}
