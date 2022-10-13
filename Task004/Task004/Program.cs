using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите действительное значение x:");
            double x = double.Parse(Console.ReadLine());
            double y = (x*x + 10)/(Math.Sqrt(x*x + 1));
            Console.WriteLine("f(x) = " + y);
            Console.ReadKey();
        }
    }
}
