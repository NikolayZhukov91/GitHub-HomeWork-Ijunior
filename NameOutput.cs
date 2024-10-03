using System;

namespace Name_output
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char userChar;
            string userName;
            int stringLenght;
            string frame = "";
            int additionalForFrame = 2;

            Console.WriteLine("Введите символ:");
            userChar = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите ваше Имя:");
            userName = Console.ReadLine();

            stringLenght = userName.Length;
            
            for (int i = 0; i < (stringLenght + additionalForFrame); i++)
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
