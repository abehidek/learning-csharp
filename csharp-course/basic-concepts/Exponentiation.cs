using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_course.basic_concepts
{
    class Exponentiation
    {
        public static void CalculateExponentiation()
        {
            bool getOut = false;
            while (!getOut)
            {
                Console.Clear();
                Console.Write("Type the base: ");
                double baseNum = Convert.ToDouble(Console.ReadLine());
                Console.Write("Type the exponent: ");
                double powNum = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("The result is: " + GetPow(baseNum, powNum));

                // BREAK THE WHILE
                Console.WriteLine("\n\n");
                Console.Write("Do you want to make another operation? (Y/N): ");
                string anotherOp = Console.ReadLine();
                if (anotherOp == "N" || anotherOp == "n" || anotherOp == "no")
                    getOut = true;
            }
            
        }
        static double GetPow(double baseNum, double powNum)
        {
            double res = 1;
            for (int i = 0; i < powNum; i++)
                res = res * baseNum;
            return res;
        }
    }
}
