using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите координаты первой вершины треугольника(сначала координату x, в следующей строке координату y).");
            double a1 = double.Parse(Console.ReadLine());
            double a2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координаты следующей вершины треугольника(таким же образом).");
            double b1 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координаты последней вершины треугольника(таким же образом).");
            double c1 = double.Parse(Console.ReadLine());
            double c2 = double.Parse(Console.ReadLine());

            double p = Math.Sqrt((b2 - b1)*(b2 - b1) + (a2 - a1)*(a2 - a1)) + Math.Sqrt((b2 - b1) * (b2 - b1) + (c2 - c1) * (c2 - c1))+ Math.Sqrt((c2 - c1) * (c2 - c1) + (a2 - a1) * (a2 - a1));
            double s = Math.Abs((b1-a1)*(c2-a2)-(c1-a1)*(b2-a2)) / 2;

            Console.WriteLine("Периметр треугольника = " + p);
            Console.WriteLine("Площадь треугольника = " + s);

            Console.ReadKey();
        }
    }
}
