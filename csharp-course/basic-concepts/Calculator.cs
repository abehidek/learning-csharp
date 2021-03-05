using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_course.basic_concepts
{
    class Calculator
    {
        public static void Calculate()
        {
            bool getOut = false;
            while (!getOut)
            {
                Console.Clear();
                Console.WriteLine("This program is a calculator");
                Console.Write("Type your number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Type the operator: ");
                string op = Console.ReadLine();

                Console.Write("Type another number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                if (op == "+")
                    Console.WriteLine("The result is " + (num1 + num2));
                else if (op == "-")
                    Console.WriteLine("The result is " + (num1 - num2));
                else if (op == "*")
                    Console.WriteLine("The result is " + (num1 * num2));
                else if (op == "/")
                    Console.WriteLine("The result is " + (num1 / num2));
                else
                    Console.Write("Invalid Operator");

                Console.WriteLine("\n\n");
                Console.Write("Do you want to make another operation? (Y/N): ");
                string anotherOp = Console.ReadLine();
                if (anotherOp == "N" || anotherOp == "n" || anotherOp == "no")
                    getOut = true;
            }
        }
    }
}
