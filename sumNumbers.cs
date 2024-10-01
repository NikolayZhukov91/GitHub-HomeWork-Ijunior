using System;

namespace The_sum_of_the_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int number = rand.Next(0, 100);
            int sumNumbers = 0;

            Console.WriteLine($"{number} - рандом");

            for (int i = 0; i <= number; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sumNumbers += i;
                    Console.WriteLine($"{i} - i");
                    Console.WriteLine($"{sumNumbers} - сумма чисел");
                }
            }

            Console.ReadKey();
        }
    }
}
