using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Local_maxima
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] elements = new int[30];
            Random random = new Random();
            int lowerBound = 0;
            int upperBound = 101;
            int number = 1;
            int forFistIndex = 0;

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < elements.Length; i++)
            {
                elements[i] = random.Next(lowerBound, upperBound);
                Console.Write(elements[i] + " ");
            }

            Console.WriteLine("\n");
            Console.WriteLine("Локальные максимумы:");

            if (elements[forFistIndex] > elements[forFistIndex + number])
            {
                    Console.Write(elements[forFistIndex] + " ");
            }
            
            for (int i = 1; i < (elements.Length - number); i++)
            {
                if (elements[i - number] < elements[i] && elements[i] > elements[i + number])
                {
                    Console.Write(elements[i] + " ");
                }
            }

            if (elements[elements.Length - number] > elements[elements.Length - number - number])
            {
                Console.Write(elements[elements.Length - number] + " ");
            }
            Console.ReadKey();
        }   
    }
}
