using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_course.basic_concepts
{
    class BasicConcepts
    {
        public static void AllBasicConcepts()
        {
            int exit = 0;
            while (exit != 1)
            {
                Console.Clear();
                Console.WriteLine("Welcome, here are the programs that i developed while i was learning basic concepts of the language");
                Console.WriteLine("\n1 - Calculator (the four basic operations)");
                Console.WriteLine("2 - Guess Game");
                Console.WriteLine("3 - Exponentiation");
                Console.WriteLine("4 - Exit");
                Console.Write("\nSelect one option: ");
                string response = Console.ReadLine();
                switch (response)
                {
                    default:
                        Console.WriteLine("Wrong option, just type '1','2','3' or '4'");
                        break;
                    case "1":
                        Calculator.Calculate();
                        break;
                    case "2":
                        GuessGame.Game();
                        break;
                    case "3":
                        Exponentiation.CalculateExponentiation();
                        break;
                    case "4":
                        exit = 1;
                        break;
                }
            }
            Console.Write("You choose exit, goodbye");
            Console.ReadLine();
        }
    }
}
