using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, unit, ten, hundred;
            Console.WriteLine("В трехзначном числе x зачеркнули вторую цифру. Когда к оставшемуся двузначному числу приписали эту цифру справа, получилось число n.");
            Console.WriteLine("Введите число n(100<=n<=999, и число десятков не равно нулю)");
            n = int.Parse(Console.ReadLine());
            unit = n % 10;
            hundred = n / 100;
            ten = (n - hundred*100)/ 10;
            int x = hundred * 100 + ten + unit * 10;
            Console.WriteLine("Число x = " + x);
            Console.ReadKey();
        }
    }
}
