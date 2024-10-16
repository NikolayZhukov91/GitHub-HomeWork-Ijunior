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
            int forLastIndex = elements.Length - 2;


            Console.WriteLine("Исходный массив:");

            for (int i = 0; i < elements.Length; i++)
            {
                elements[i] = random.Next(lowerBound, upperBound);
                Console.Write(elements[i] + " ");
            }

            Console.WriteLine("\n");
            Console.WriteLine("Локальные максимумы:");

            if (elements[0] > elements[1])
            {
                    Console.Write(elements[0] + " ");
            }
            
            for (int i = 1; i < (elements.Length - 1); i++)
            {
                if (elements[i - 1] < elements[i] && elements[i] > elements[i + 1])
                {
                    Console.Write(elements[i] + " ");
                }
            }

            if (elements[forLastIndex] < elements[elements.Length - 1])
            {
                Console.Write(elements[elements.Length - 1] + " ");
            }
            Console.ReadKey();
        }   
    }
}
