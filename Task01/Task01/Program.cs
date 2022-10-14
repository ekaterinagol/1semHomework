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
            Console.WriteLine("Живые взоры я встречаю...\nОгня, огня! Костер готов.\nЯ к ближним руки простираю,\nЯ жду движенья, знака, слов...\n\nС какою радостною мукой\nВ очах людей ловлю я свет!\nНо говорю... и дышит скукой\nИх утомительный ответ.\n\nЯ отступаю, безоружный,\nИ длю я праздный разговор,\nИ лью я воду на ненужный,\nНа мой безогненный костер.\n\nО, как понять, что это значит?\nКого осудим, – их? меня?\nДуша обманутая плачет...\nКостер готов – и нет меня.");

            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
