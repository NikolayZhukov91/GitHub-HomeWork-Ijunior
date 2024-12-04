using System;

namespace Split
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char space = ' ';
            string text = "Привет, я выполняю домашние задания в IJunior";
            string[] words = text.Split(space);

            foreach (string subText in words)
            {
                Console.WriteLine($"Substring: {subText}");
            }

            Console.ReadKey();
        }
    }
}
