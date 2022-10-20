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
            double x = Sinuss(2,3) + Sinuss(5,7) + Sinuss(11,13);
            Console.WriteLine("x = " + x);
            Console.ReadKey();
        }
        static double Sinuss(double x,double y)
        {
            return Math.Round(((Math.Sin(x)+Math.Sin(y))/(x+y)),3);
        }
    }
}
