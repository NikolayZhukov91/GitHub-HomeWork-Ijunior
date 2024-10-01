using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExitControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string codeWord = "exit";
            
            Console.WriteLine($"Программа будет выполняться пока вы не введете команду {codeWord}.");
            Console.WriteLine("Введите команду:");

            while (Console.ReadLine() != codeWord)
            {
                                
            }

            Console.WriteLine("Программа завершает работу");
            Console.ReadKey();
        }
    }
}
