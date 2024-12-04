using System;

namespace Split
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char separator = ' ';
            string text = "Привет, я выполняю домашние задания в IJunior";
            string[] word = text.Split(separator);

            foreach (string subText in word)
            {
                Console.WriteLine($"Substring: {subText}");
            }

            Console.ReadKey();
        }
    }
}
