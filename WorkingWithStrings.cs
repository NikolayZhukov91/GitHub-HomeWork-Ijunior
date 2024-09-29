using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfUser;
            string ageOfUser;
            string zodiacOfUser;
            string jobOfUser;

            Console.WriteLine("Привет! как тебя зовут?");
            nameOfUser = Console.ReadLine();
            Console.WriteLine("Сколько тебе лет?");
            ageOfUser = Console.ReadLine();
            Console.WriteLine("Какой твой знак зодиака?");
            zodiacOfUser = Console.ReadLine();
            Console.WriteLine("Кем ты работаешь?");
            jobOfUser = Console.ReadLine();


            Console.WriteLine($"Вас зовут {nameOfUser}, вам {ageOfUser}, вы {zodiacOfUser} и работаете {jobOfUser}");
            Console.ReadKey();
        }
    }
}
