using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegreeOfTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lowerbound = 0;
            int upperbound = 101;
            int numberTwo = 2;
            int resultOfNumber = 1;
            int number;
            int degreeCounter = 0;
            int additionalNumber = 1;


            Random ranodom = new Random();
            number = ranodom.Next(lowerbound,upperbound);

            while (number >= resultOfNumber)
            {
                resultOfNumber *= numberTwo;
                degreeCounter ++;
            }

            Console.WriteLine($"Число - {number}, степень - {degreeCounter}, число в степени {resultOfNumber}");
            
            Console.ReadKey();
        }
    }
}
