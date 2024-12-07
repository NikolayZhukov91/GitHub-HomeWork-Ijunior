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
            int result;
            
            while (int.TryParse(consoleInput, out result))
            {
                Console.Write("Пожалуйста, введите целое число: ");
                
                string consoleInput = Console.ReadLine();
            }
        }
    }
}