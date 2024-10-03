using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplesOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lowerBound = 10;
            int upperBound = 25;
            int conditionalMinimumNumber = 50;
            int conditionalMaximumNumber = 150;
            int MultiplesOfNumbers = 0;
            
            Random random = new Random();
            int number = random.Next(lowerBound, upperBound);

            for (int i = number; i <= conditionalMaximumNumber; i += number)
            {
                
                for (int j = i; j <= conditionalMinimumNumber; j += number)
                {
                    Console.WriteLine(j);
                    i = j;
                }

                MultiplesOfNumbers++;
                Console.WriteLine(MultiplesOfNumbers);
            }

            Console.WriteLine($"Количество чисел от {conditionalMinimumNumber} до {conditionalMaximumNumber}, которые кратны {number} равно {MultiplesOfNumbers}.");
            Console.ReadKey();
        }
    }
}
