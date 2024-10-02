using System;

namespace sequence.v3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int initialNumber = 5;
            int maxValue = 789;
            int step = 7;

            Console.WriteLine(initialNumber);

            for (int i = initialNumber; i <= maxValue; i += step)
            {
                Console.WriteLine(initialNumber);
            }

            Console.ReadKey();
        }
    }
}
