﻿using System;

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
            Console.WriteLine("Живые взоры я встречаю...
Огня, огня! Костер готов.
Я к ближним руки простираю,
Я жду движенья, знака, слов...

С какою радостною мукой
В очах людей ловлю я свет!
Но говорю... и дышит скукой
Их утомительный ответ.

Я отступаю, безоружный,
И длю я праздный разговор,
И лью я воду на ненужный,
На мой безогненный костер.

О, как понять, что это значит?
Кого осудим, – их? меня?
Душа обманутая плачет...
Костер готов – и нет меня.");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
