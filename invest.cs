using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float money;
            int years;
            int percent;

            Console.WriteLine("Введидте количества денег, внесенных на вклад:");
            money = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("На сколько лет открыт вклад?");
            years = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Под какой процент?");
            percent = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < years; i++)
            {
                money += money / 100 * percent;
                Console.WriteLine($"В этом году у вас {money} денег.");
                Console.ReadKey();
            }
        }
    }
}
