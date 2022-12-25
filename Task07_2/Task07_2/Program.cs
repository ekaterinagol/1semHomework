using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.ReadKey();
        }

        static bool BelongsToArea()
        {
            Console.WriteLine("Введите x:");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите y:");
            double y = double.Parse(Console.ReadLine());
            if ((y >= -2)&(y<=1,5))
            {
                return true;
            }

        }
    }
}
