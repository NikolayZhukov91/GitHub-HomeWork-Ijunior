using System;

namespace MultiplesOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lowerBound = 10;
            int upperBound = 25;
            int addNumber =  1;
            int conditionalMinimumNumber = 50;
            int conditionalMaximumNumber = 150;
            int multiplesOfNumbers = 0;
            
            Random random = new Random();
            int number = random.Next(lowerBound, upperBound+addNumber);

            for (int i = 0; i <= conditionalMaximumNumber; i += number)
            {
                if (i >= conditionalMinimumNumber) 
                {
                multiplesOfNumbers++;
                Console.WriteLine(multiplesOfNumbers);
                Console.WriteLine(i);
                }
            }

            Console.WriteLine($"Количество чисел от {conditionalMinimumNumber} до {conditionalMaximumNumber}, которые кратны {number} равно {multiplesOfNumbers}.");
            Console.ReadKey();
        }
    }
}
