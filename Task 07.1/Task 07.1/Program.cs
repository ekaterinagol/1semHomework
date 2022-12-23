using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_07_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalculateBool());

            Console.ReadKey();
        }

        static int EnterNumber()
        {
            Console.WriteLine(@"Введите число:");
            int x = int.Parse(Console.ReadLine());
            return x;
        }

        static bool CalculateBool()
        {
            bool negative;
            if ((EnterNumber() <= 0) & (EnterNumber() <= 0) & (EnterNumber() <= 0))
            {
                negative = true;
            }
            else
            {
                negative = false;
            }
            return negative;
        }
    }
}
