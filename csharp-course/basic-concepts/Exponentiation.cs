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
            Console.Clear();
            Console.Write("Digite a base: ");
            double baseNum = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o expoente: ");
            double powNum = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Seu resultado é: " + GetPow(baseNum, powNum));
            Console.ReadLine();
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
