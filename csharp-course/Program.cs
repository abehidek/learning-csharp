using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// IMPORTING NAMESPACES
using csharp_course.basic_concepts;
using csharp_course.poo_concepts;

namespace csharp_course
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Adam", "Physics", 3.2);
            Student student2 = new Student("Beatrice", "Literature", 3.9);

            Console.WriteLine(student1.HasHonnors());
            Console.WriteLine(student2.HasHonnors());

            Console.ReadLine();
            /*
            int exit = 0;
            while (exit != 1)
            {
                Console.Clear();
                Console.WriteLine("Bem vindo ao programa principal, aqui estão as opções: ");
                Console.WriteLine("\n1 - Calculadora Aritmética");
                Console.WriteLine("2 - Guess Game");
                Console.WriteLine("3 - Potência");
                Console.WriteLine("4 - Sair");
                Console.Write("\nGostaria de fazer o que? : ");
                string response = Console.ReadLine();
                switch (response)
                {
                    default:
                        Console.WriteLine("Você digitou errado");
                        break;
                    case "1":
                        Calculator.Calculate();
                        break;
                    case "2":
                        GuessGame.Game();
                        break;
                    case "3":
                        Power.CalculatePower();
                        break;
                    case "4":
                        exit = 1;
                        break;
                }
            }
            Console.WriteLine("Você escolheu sair do programa, Adeus");
            Console.ReadLine();
            */
        }
    }
}
