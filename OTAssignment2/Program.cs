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
                    TriangleDimensions();
                }
            }
        }

        private static void TriangleDimensions()
        {
            Console.Write("Input first number: ");
            string a = Console.ReadLine();
            Console.Write("Input second number: ");
            string b = Console.ReadLine();
            Console.Write("Input third number: ");
            string c = Console.ReadLine();

            ParseInput(a, b, c);
        }

        private static void ParseInput(string a, string b, string c)
        {
            try
            {
                int sideA = int.Parse(a);
                int sideB = int.Parse(b);
                int sideC = int.Parse(c);

                if (sideA < 0 || sideB < 0 || sideC < 0)
                {
                    Console.WriteLine("Please enter only positive digits!");
                    TriangleDimensions();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter only positive digits!");
                TriangleDimensions();
            }
        }
    }
}
