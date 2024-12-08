using System;

namespace ReadInt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int result = ReadInt();
            Console.WriteLine($"Введенное число: {result}");
            Console.ReadKey();
        }

        static int ReadInt()
        {
            string consoleInput;
            int result;

            Console.Write("Пожалуйста, введите целое число: ");
            consoleInput = Console.ReadLine();

            while (!int.TryParse(consoleInput, out result))
            {
                Console.Write("Строка не число. ");
                Console.Write("Пожалуйста, введите целое число: ");

                consoleInput = Console.ReadLine();
            }

            return result;
        }
    }
}