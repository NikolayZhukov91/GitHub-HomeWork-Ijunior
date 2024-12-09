using System;

namespace UIElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int healthPercent = 50, maxHealth = 10;
            int manaPercent = 70, maxMana = 10;

            while (true)
            {
                DrawBar(healthPercent, maxHealth, ConsoleColor.Green, 0, '#');
                DrawBar(manaPercent, maxMana, ConsoleColor.Blue, 1);

                Console.SetCursorPosition(0, 5);
                Console.WriteLine("Ввдите процент на который изменится жизни:");
                healthPercent += Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ввдите процент на который изменится мана:");
                manaPercent += Convert.ToInt32(Console.ReadLine());
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void DrawBar(int valuePercent, int maxValue, ConsoleColor color, int position, char symbol = '|')
        {
            ConsoleColor defaultColor = Console.BackgroundColor;

            string bar = "";

            for (int i = 0; i < (valuePercent/maxValue); i++)
            {
                bar += symbol;
            }

            Console.SetCursorPosition(0, position);
            Console.Write("[");
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.BackgroundColor = defaultColor;

            bar = "";

            for (int i = (valuePercent / maxValue); i < maxValue; i++)
            {
                bar += " ";
            }

            Console.Write(bar + ']');
        }
    }
}
