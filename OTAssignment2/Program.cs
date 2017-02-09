using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            StartMenu();
        }

        private static void StartMenu()
        {
            string userInput = "";
            while (userInput != "2")
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Enter triangle dimensions");
                Console.WriteLine("2. Exit");
                Console.Write("Make your selection now: ");
                userInput = Console.ReadLine();
                if (userInput == "1")
                {
                    triangleDimensions();
                }
            }
        }

        private static void triangleDimensions()
        {
            Console.Write("Input first number: ");
            string a = Console.ReadLine();
            Console.Write("Input second number: ");
            string b = Console.ReadLine();
            Console.Write("Input third number: ");
            string c = Console.ReadLine();
        }
    }
}
