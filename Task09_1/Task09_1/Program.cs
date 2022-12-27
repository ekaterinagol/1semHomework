using System;


namespace Task09_1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите курс доллара(относительно рубля):");
            double dollarExchangeRate = double.Parse(Console.ReadLine());
            ExchangeTable(dollarExchangeRate);
            
            Console.ReadKey();  
        }

        static void ExchangeTable(double s)
        {
            for (int i = 10; i < 1001 ; i = i + 10)
            {
                Console.WriteLine(i + "$" + MakeSpacesForGoodloookingTable(i)+ "| " + (i * s)+ " руб.");
            }
        }

        static string MakeSpacesForGoodloookingTable(int s)
        {
            string spaces = "       ";
            int digitNumber = 0;
            while (s > 0)
            {
                s = s / 10;
                digitNumber++;
            }
            int StartIndex = 0;
            spaces = spaces.Substring(StartIndex, (7 - digitNumber));
            return spaces;           
        }

    }
}
