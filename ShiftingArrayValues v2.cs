using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shifting_array_values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int numberShiftCycles;
            
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i]);
            }

            Console.Write("\n");
            Console.WriteLine("Ввдете количество сдвигов влево");
            numberShiftCycles = Convert.ToInt32(Console.ReadLine());

            numberShiftCycles %= numbers.Length;

            for (int i = 0; i < numberShiftCycles; i++)
            {
                int firstItem = numbers[0];

                for (int j = 1; j < numbers.Length; j++)
                {
                    numbers[j-1] = numbers[j];
                }

                numbers[numbers.Length - 1] = firstItem;
            }

            for (int i = 0;i < numbers.Length; i++)
            {
                Console.Write(numbers[i]);
            }

            Console.ReadKey();
        }
    }
}
