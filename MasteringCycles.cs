using System;

namespace Mastering_cycles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberMessages;
            string message;

            Console.WriteLine("Введите ваше сообщение:");
            message = Console.ReadLine();
            Console.WriteLine("Сколько раз повторить сообщение?");
            numberMessages = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i<numberMessages; i++)
            {
                Console.WriteLine(message);
            }
            Console.ReadKey();
        }
    }
}
