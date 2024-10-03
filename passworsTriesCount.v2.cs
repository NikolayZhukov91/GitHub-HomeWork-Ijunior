using System;

namespace passworsTriesCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int triesCount = 3;
            string password = "123456";
            string userInput;
            int additionalAttempt = 1;

            for (int i = 0; i < triesCount; i++)
            {
                Console.WriteLine("Введите пароль:");
                userInput = Console.ReadLine();
                
                if (userInput == password)
                {
                    Console.WriteLine("Секретное сообщение");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("Пароль не верный");
                    Console.WriteLine("У вас осталось попыток " + (triesCount - (i + additionalAttempt)));
                }
                
            }
        }
    }
}
