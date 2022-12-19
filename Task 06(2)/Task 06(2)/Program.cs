using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_06_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "клоун";
            Console.WriteLine(word, " {0},{3},{1},{2},{4}");
            Console.WriteLine($"Из слова {word}, мы сделали слово {word[0]}{word[3]}{word[1]}{word[2]}{word[4]}");

            Console.ReadKey();
        }
    }

}
