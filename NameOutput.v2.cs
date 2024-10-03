using System;

namespace Name_output
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char userChar;
            string userName;
            string middleLine;
            string frame = "";

            Console.WriteLine("Введите символ:");
            userChar = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите ваше Имя:");
            userName = Console.ReadLine();

            middleLine = userChar + userName + userChar;

            for (int i = 0; i < (middleLine.Length); i++)
            {
                frame += userChar;
            }

            Console.WriteLine(frame);
            Console.WriteLine(userChar + userName + userChar);
            Console.WriteLine(frame);
            Console.ReadKey();

        }
    }
}
