using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working_with_specific_rows_columns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = new int[4, 4];
            Random random = new Random();

            int lowerBoundRandom = 1;
            int upperBoundRandom = 10;
            int amountOfSummation = 0;
            int indexOfSummation = 1;
            int productOfMultiplication = 1;
            int indexOfMultiplication = 0;
            int additionalNumber = 1;

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    numbers[i, j] = random.Next(lowerBoundRandom, upperBoundRandom);
                    Console.Write(numbers[i, j] + " ");
                }

                Console.WriteLine();
            }
            
            for(int j = 0; j < numbers.GetLength(1); j++)
            {
                amountOfSummation += numbers[indexOfSummation, j];
            }

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                productOfMultiplication *= numbers[i,indexOfMultiplication];
            }

            Console.WriteLine($"{amountOfSummation} - сумма {indexOfSummation + additionalNumber } строки");
            Console.WriteLine($"{productOfMultiplication} - произведение {indexOfMultiplication + additionalNumber} столбца");
            Console.ReadKey();
        }
    }
}