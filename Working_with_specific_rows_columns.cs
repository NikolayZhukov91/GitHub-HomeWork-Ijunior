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
            int[,] array = new int[4, 4];
            Random random = new Random();

            int lowerBoundRandom = 1;
            int upperBoundRandom = 10;
            int amountOfSecondLine = 0;
            int indexOfSecondLine = 1;
            int productOfFirstColumn = 1;
            int indexOfFirstColumn = 0;


            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(lowerBoundRandom, upperBoundRandom);
                    Console.Write(array[i, j] + " ");
                    if (i == indexOfSecondLine)
                    {
                        amountOfSecondLine += array[i, j];
                    }
                    if (j == indexOfFirstColumn)
                    {
                        productOfFirstColumn *= array[i, j];
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine($"{amountOfSecondLine} - сумма второй строки");
            Console.WriteLine($"{productOfFirstColumn} - произведение первого столбца");
            Console.ReadKey();
        }
    }
}