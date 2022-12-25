using System;


namespace Task_07_1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine(CalculateBool());

            Console.ReadKey();
        }

        static bool CalculateBool()
        {
            if ((EnterNumber("k") <= 0) & (EnterNumber("m") <= 0) & (EnterNumber("n") <= 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        static int EnterNumber(string name)
        {
            Console.WriteLine($"Введите число {name}:");
            int x = int.Parse(Console.ReadLine());
            return x;
        }
    }
}
