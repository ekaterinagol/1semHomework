using System;


namespace Task07_2
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Принадлежит ли данная точка указанной области?\n"+BelongsToArea());

            Console.ReadKey();
        }

        static bool BelongsToArea()
        {
            double x = EnterNumber("x");
            double y = EnterNumber("y");
            if ((y <= 1.5) & (y >= -2))
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        static double EnterNumber(string name)
        {
            Console.WriteLine($"Введите число {name}:");
            double x = double.Parse(Console.ReadLine());
            return x;
        }
    }
}
