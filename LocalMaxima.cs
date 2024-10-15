using System;

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

            for (int i = 0; i < elements.Length; i++)
            {
                if (i == forFistIndex)
                {
                    if (elements[i] > elements[i + number])
                    {
                        Console.Write(elements[i] + " ");
                    }
                }

                else if (i == (elements.Length - number))
                {
                    if (elements[i - number] < elements[i])
                    {
                        Console.Write(elements[i] + " ");
                    }
                }

                else 
                {    
                    if (elements[i - number] < elements[i] && elements[i] > elements[i + number])
                    {
                        Console.Write(elements[i] + " ");
                    }
                }
            }
            Console.ReadKey();
        }   
    }
}
