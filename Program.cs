﻿using System;
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

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();

            Console.WriteLine("What is yor age?");
            int userAge = int.Parse(Console.ReadLine());

            Console.WriteLine("What month were you born in? (Please enter month in numerical form 1-12)");
            int birthMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your favorite ROYGBIV colour? Please enter \"Help\" to get a list of colours.");
            string colour = Console.ReadLine();
            if (colour.ToLower() == "help")
                {
                Console.WriteLine("R is for red" + "\n" + "O is for orange" + "\n" + "Y is for yellow" + "\n" + "G is for green" + "\n" + "B is for blue" + "\n" + "I is for indigo" + "\n" + "V is for violet");
            } 
            else
            {
                string colour = Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}
