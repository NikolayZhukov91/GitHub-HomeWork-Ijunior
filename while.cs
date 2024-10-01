using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;

            Console.WriteLine("Введите ва возраст:");

            age = Convert.ToInt32(Console.ReadLine());

            while (age-- > 0)
            {
                if (age == 3)
                {
                    continue;
                }
                Console.WriteLine(age);
                
                if (age == 9)
                {
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
