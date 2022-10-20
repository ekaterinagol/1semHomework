using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = sinuss(2,3) + sinuss(5,7) + sinuss(11,13);
            Console.WriteLine("x = " + x);
            Console.ReadKey();
        }
        static double sinuss(double x,double y)
        {
            return Math.Round(((Math.Sin(x)+Math.Sin(y))/(x+y)),3);
        }
    }
}
