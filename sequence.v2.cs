using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sequence.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNumber = 5;
            int maxValue = 789;
            int step = 7;

            Console.WriteLine(startNumber);

            for (int i = startNumber; i <= maxValue; i++)
            {
                if (i % step == 0)
                {                    
                    startNumber += step;
                    Console.WriteLine(startNumber);
                }
                
            }

            Console.ReadKey();
        }
    }
}
