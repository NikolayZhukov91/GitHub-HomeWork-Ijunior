using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastering_cycles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberMessage;
            string message;

            Console.WriteLine("Введите ваше сообщение:");
            message = Console.ReadLine();
            Console.WriteLine("Сколько раз повторить сообщение?");
            numberMessage = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i<numberMessage; i++)
            {
                Console.WriteLine(message);
            }
            Console.ReadKey();
        }
    }
}
