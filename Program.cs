using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gladiatorFights
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            float health1 = rand.Next(90,100);
            int damage1 = rand.Next(5, 20);
            int armor1= rand.Next(25,55);

            float health2 = rand.Next(80, 100);
            int damage2= rand.Next(20,40);
            int armor2= rand.Next(65,100);

            Console.WriteLine($"Гладиатор 1 - {health1} здровье, {damage1} урон, {armor1} броня.");
            Console.WriteLine($"Гладиатор 2 - {health2} здровье, {damage2} урон, {armor2} броня.");

            while(health1 > 0 && health2 >0)
            {
                health1 -= Convert.ToSingle(rand.Next(0, damage2 + 1)) / 100 * armor1;
                health2 -= Convert.ToSingle(rand.Next(0, damage1 + 1)) / 100 * armor2;

                Console.WriteLine($"Здоровье гладиатора 1 {health1}.");
                Console.WriteLine($"Здоровье гладиатора 2 {health2}.");
            }
            if (health1 <= 0 && health2 <= 0)
            {
                Console.WriteLine("Оба гладиатора погибли, ничья.");
            }
            else if (health1 <= 0)
            {
                Console.WriteLine("Победил второй гладиатор");
            }
            else if (health2 <= 0)
            {
                Console.WriteLine("Победил первый гладиатор");
            }
            Console.ReadKey();
        }
    }
}
