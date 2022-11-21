using System;

namespace Task_08
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите значение x:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("f(x) = " + yFromX(x));

            Console.ReadKey();
        }
        static double yFromX(double x)
        {
            if (x < -2) { return -2; }
            else if (x > 2) { return 2; }
            else { return x; }
        }
    }
}
