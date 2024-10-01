using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNumber = 5;
            int maxValue = 789;
            int step = 7;

            while (startNumber < maxValue)
            {
                startNumber += step;
                Console.WriteLine(startNumber);
            }

            Console.ReadKey();
        }
    }
}
