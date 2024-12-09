using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace UIElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int healthPercent = 5;
            int maxLengthHealth = 10;
            int manaPercent = 7;
            int maxLengthMana = 10 ;
            bool isWork = true;
            
            while (isWork)
            {
                DrawBar(healthPercent, maxLengthHealth, ConsoleColor.Green, 0, '#');
                DrawBarContinuation(healthPercent, maxLengthHealth, ConsoleColor.Green, 0, '#');
                DrawBar(manaPercent, maxLengthMana, ConsoleColor.Blue, 1);
                DrawBarContinuation(healthPercent, maxLengthHealth, ConsoleColor.Green, 0, '|');

                Console.SetCursorPosition(0, 5);
                Console.WriteLine("Введите размер бара жизней:");
                maxLengthHealth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите процент жизней:");
                healthPercent = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите размер бара маны:");
                maxLengthMana = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите процент маны:");
                manaPercent = Convert.ToInt32(Console.ReadLine());
                Console.ReadKey();
                Console.Clear();

            }
        }

        static void DrawBar(int valuePercent, int maxLength, ConsoleColor color, int position, char symbol = '|')
        {
            int oneHundredPercent = 100;
            ConsoleColor defaultColor = Console.BackgroundColor;
            string bar = "";

            for (int i = 0; i < (valuePercent*maxLength/ oneHundredPercent); i++)
            {
                bar += symbol;
            }

            Console.SetCursorPosition(0, position);
            Console.Write("[");
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.BackgroundColor = defaultColor;
        }

        static void DrawBarContinuation(int valuePercent, int maxLength, ConsoleColor color, int position, char symbol = '|')
        {
            int oneHundredPercent = 100;
            string bar = "";

            for (int i = (valuePercent * maxLength / oneHundredPercent); i < maxLength; i++)
            {
                bar += " ";
            }

            Console.Write(bar + ']');
        }
    }
}
