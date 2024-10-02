using System;

namespace ConsoleMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const string CommandShowText = "1";
            const string CommandClearConsole = "2";
            const string CommandRandom  = "3";
            const string CommandExit = "4";

            bool isWork = true;
            string userInput;
            int minValueRandom = 0;
            int maxValueRandom = 100;

            Random random = new Random();
            int randomNumber;

            while (isWork)
            {
                Console.WriteLine("Привет! Возможные команды:");
                Console.WriteLine("Показать 'Hello, World!': команда - '1'");
                Console.WriteLine("Очистить консоль: команда - '2'");
                Console.WriteLine("Вывести случайное число: команда - '3'");
                Console.WriteLine("Выйти из программы: команда - '4'");

                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case CommandShowText:
                        Console.WriteLine("Hello, World!");
                        break;
                    case CommandClearConsole:
                        Console.Clear();
                        break;
                    case CommandRandom:
                        randomNumber = random.Next(minValueRandom, maxValueRandom);
                        Console.WriteLine(randomNumber);
                        break;
                    case CommandExit:
                        isWork = false;
                        Console.WriteLine("Выход из программы");
                        break;
                    default:
                        Console.WriteLine("Такой команды нет.");
                        break;
                }
            }
        }
    }
}
