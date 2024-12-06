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
            
            while (true)
            {
                Console.Write("Пожалуйста, введите целое число: ");
                string consoleInput = Console.ReadLine();
                
                if (int.TryParse(consoleInput, out result))
                {
                    return result;
                    break;
                }
                else
                {
                    Console.WriteLine("Неверный ввод. Пожалуйста, попробуйте снова.");
                }
            }

            
        }
    }
}