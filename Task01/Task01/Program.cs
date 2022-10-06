using System;

namespace Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Костер");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Зинаида Гиппиус");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Живые взоры я встречаю...\r\nОгня, огня! Костер готов.\r\nЯ к ближним руки простираю,\r\nЯ жду движенья, знака, слов...\r\n\r\nС какою радостною мукой\r\nВ очах людей ловлю я свет!\r\nНо говорю... и дышит скукой\r\nИх утомительный ответ.\r\n\r\nЯ отступаю, безоружный,\r\nИ длю я праздный разговор,\r\nИ лью я воду на ненужный,\r\nНа мой безогненный костер.\r\n\r\nО, как понять, что это значит?\r\nКого осудим, – их? меня?\r\nДуша обманутая плачет...\r\nКостер готов – и нет меня.");

            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
