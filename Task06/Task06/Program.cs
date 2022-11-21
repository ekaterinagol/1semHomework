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
            Console.WriteLine("Введите текст на русском:");
            string s = Console.ReadLine();
            string newS = s.ToUpper();
            Console.WriteLine("Текст транслитерацией:");
            Console.WriteLine(convert(newS));


            Console.ReadKey();
        }
        static string convert(string s)
        {
            s = s.Replace("А", "A");
            s = s.Replace("Б", "B");
            s = s.Replace("В", "V"); 
            s = s.Replace("Г", "G");
            s = s.Replace("Д", "D"); 
            s = s.Replace("Е", "E"); 
            s = s.Replace("Ё", "E");
            s = s.Replace("Ж", "ZH");
            s = s.Replace("З", "Z"); 
            s = s.Replace("И", "I");
            s = s.Replace("К", "K");
            s = s.Replace("Л", "L");
            s = s.Replace("М", "M"); 
            s = s.Replace("Н", "N");
            s = s.Replace("О", "O"); 
            s = s.Replace("П", "P");
            s = s.Replace("Р", "R");
            s = s.Replace("С", "S");
            s = s.Replace("Т", "T");
            s = s.Replace("У", "U");
            s = s.Replace("Ф", "F");
            s = s.Replace("Х", "KH");
            s = s.Replace("Ц", "TS");
            s = s.Replace("Ч", "CH");
            s = s.Replace("Ш", "SH");
            s = s.Replace("Щ", "SHCH");
            s = s.Replace("Ъ", "IE");
            s = s.Replace("Ы", "Y");
            s = s.Replace("Ь", "");
            s = s.Replace("Э", "E");
            s = s.Replace("Ю", "IU");
            s = s.Replace("Я", "IA");

            return s;
        }
    }
}
