using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово:");
            string s = Console.ReadLine();
            string newS = s.ToUpper();
            Console.WriteLine(convert(newS));


            Console.ReadKey();
        }
        static string convert(string x="A")
        {
            return "S";
        }
    }
}
