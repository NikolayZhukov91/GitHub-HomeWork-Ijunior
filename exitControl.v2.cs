using System;

namespace ExitControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string codeWord = "exit";
            string message = "continue";

            Console.WriteLine($"Программа будет выполняться пока вы не введете команду {codeWord}.");

            while (message != codeWord)
            {
                Console.WriteLine("Введите команду:");
                message = Console.ReadLine();
            }

            Console.ReadKey();
        }
    }
}
