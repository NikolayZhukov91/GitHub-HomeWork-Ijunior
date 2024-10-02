using System;

namespace The_sum_of_the_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumNumbers = 0;
            int minValueRandom = 0;
            int maxValueRandom = 100;
            int numberFirstCondition = 3;
            int numberSecondCondition = 5;
            Random random = new Random();
            int number = random.Next(minValueRandom, maxValueRandom);
            
            Console.WriteLine($"{number} - рандом");

            for (int i = 0; i <= number; i++)
            {
                if (i % numberFirstCondition == 0 || i % numberSecondCondition == 0)
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
