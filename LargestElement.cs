using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] originalMatrix = new int[10, 10];
            Random random = new Random();
            int lowerNumber = 0;
            int upperNumber = 101;
            int tempMaxValue;
            int MaxValue = 0;
            int numberReplacement = 0;

            Console.WriteLine("Исходная матрица:");
            for (int i = 0; i < originalMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < originalMatrix.GetLength(1); j++)
                {
                    originalMatrix[i, j] = random.Next(lowerNumber, upperNumber);
                    Console.Write(originalMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            
            foreach (int element in originalMatrix)
            {
                tempMaxValue = element ;
                if (tempMaxValue > MaxValue)
                {
                    MaxValue = tempMaxValue;
                }
            }

            Console.WriteLine($"Максимальное значение - {MaxValue}");
            Console.WriteLine("модифицированная матрица:");
            for (int i = 0; i < originalMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < originalMatrix.GetLength(1); j++)
                {
                    if (originalMatrix[i, j] == MaxValue)
                    {
                        originalMatrix[i, j] = numberReplacement;
                    }
                    Console.Write(originalMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
