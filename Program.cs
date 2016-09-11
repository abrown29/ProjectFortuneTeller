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
            Console.WriteLine("Let the Great Zucchini tell your future! Just answer a few simple questions...");
            Console.WriteLine("\n");

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

            string retire;
            if (userAge%2 == 0)
            {
                retire = " will retire in 90 years";
            }
            else
            {
                retire = " will retire in 25 years";
            }

            string vacationHome = "a vacation home in";
            if (userSibling == 0)
            {
                vacationHome = "a vacation home in Italy";
            }
            else if (userSibling == 1)
            {
                vacationHome = "a vacation home in Fiji";
            }
            else if (userSibling == 2)
            {
                vacationHome = "a vacation home in France";
            }
            else if (userSibling == 3)
            {
                vacationHome = "a vacation home in Long Island";
            }
            else if (userSibling > 3)
            {
                vacationHome = "a vacation home in the Bahamas";
            }
            else if (userSibling <0)
            {
                vacationHome = "a vacation home in Siberia";
            }

            string vehicle = "a";
            if (color.ToLower() == "red" || color.ToLower() == "r")
            {
                vehicle = "a horse.";
            }
            else if (color.ToLower() == "orange" || color.ToLower() == "o")
            {
                vehicle = "a helicopter.";
            }
            else if (color.ToLower() == "yellow" || color.ToLower() == "y")
            {
                vehicle = "a donkey.";
            }
            else if (color.ToLower() == "green" || color.ToLower() == "g")
            {
                vehicle = "a car.";
            }
            else if (color.ToLower() == "blue" || color.ToLower() == "b")
            {
                vehicle = "a motorcycle.";
            }
            else if (color.ToLower() == "indigo" || color.ToLower() == "i")
            {
                vehicle = "a boat.";
            }
            else if (color.ToLower() == "violet" || color.ToLower() == "v")
            {
                vehicle = "a plane.";
            }

            string money = "in bank";
            if (birthMonth >= 1 && birthMonth <= 4)
            {
                money = " with $100000 in the bank, ";
            }
            else if (birthMonth >=5 && birthMonth <=8)
            {
                money = " with $200000 in the bank, ";
            }
            else if (birthMonth >=9 && birthMonth <= 12)
            {
                money = " with $300000 in the bank, ";
            }
            else if (birthMonth <= 0 || birthMonth >= 12)
            {
                money = " with $0.00 in the bank, ";
            }

            Console.WriteLine(firstName + " " + lastName + retire + money + "\n" + vacationHome + ", and " + vehicle);
            Console.ReadKey();
        }
    }
}
