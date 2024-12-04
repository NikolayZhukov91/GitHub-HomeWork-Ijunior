using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lowerBound = 1;
            int upperBound = 10;
            int tempArgument;
            
            int[] numbers = new int[10];
            Random random = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(lowerBound, upperBound);
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();

            for (int i = 0;i < numbers.Length - 1; i++)
            {
                for (int j = 0; j<numbers.Length - 1 - i; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        tempArgument = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j+1] = tempArgument;
                    }
                }
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
