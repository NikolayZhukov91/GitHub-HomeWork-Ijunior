using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int value;

            while (true)
            {
                value = random.Next(0,10);
                Console.WriteLine(value);
                Console.ReadKey();
            }
        }
    }
}
