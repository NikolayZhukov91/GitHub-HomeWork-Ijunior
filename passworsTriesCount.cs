using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passwors___triesCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int triesCount = 5;
            string password = "123456";
            string userInput;

            for (int i = 0; i < triesCount; i++)
            {
                Console.WriteLine("Введите пароль:");
                password = Console.ReadLine();
                if (userInput == password)
                {
                    Console.WriteLine("Секретики");
                    break;
                }
                else
                {
                    Console.WriteLine("Пароль не верный");
                    Console.WriteLine("У вас осталось попыток " + (triesCount - (i + 1)) );
                }
            }
        }
    }
}
