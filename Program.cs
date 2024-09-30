using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float rublesInWallet;
            float dollarsInWallet;

            int rubToUsd = 64; int usdToRub = 66;
            float exchangeCurrencyCount;
            string desiredOperation;

            Console.WriteLine("Приветствую тебя, Сталкер! Это обменник");   

            Console.WriteLine("Введите баланс рублей:");
            rublesInWallet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите баланс долларов:");
            dollarsInWallet = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите необходимую операцию:");
            Console.WriteLine("1 - обменять рубли на доллары.");
            Console.WriteLine("2 - обменять доллары на рубли");
            Console.WriteLine("Ваш Выбор:");
            desiredOperation = Console.ReadLine();

            switch (desiredOperation)
            {
                case "1":
                    Console.WriteLine("Обмен рублей на доллары:");
                    Console.WriteLine("Сколько вы хотите обменять?");
                    exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                    if (rublesInWallet >= exchangeCurrencyCount)
                    {
                        rublesInWallet -= exchangeCurrencyCount;
                        dollarsInWallet += exchangeCurrencyCount / rubToUsd;
                    }
                    else
                    {
                        Console.WriteLine("Недопустимое количество рублей.");
                    }
                    break;
                case "2":
                    Console.WriteLine("Обмен долларов на рубли:");
                    Console.WriteLine("Сколько вы хотите обменять?");
                    exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                    if (dollarsInWallet >= exchangeCurrencyCount)
                    {
                        dollarsInWallet -= exchangeCurrencyCount;
                        rublesInWallet += exchangeCurrencyCount * usdToRub;
                    }
                    else
                    {
                        Console.WriteLine("Недопустимое количество долларов.");
                    }
                    break;
                default:
                    Console.WriteLine("Выбранна не верная операция");
                    break;
            }

            Console.WriteLine($"Ваш баланс: {dollarsInWallet} - долларов, {rublesInWallet} - рублей.");

            Console.ReadKey();


        }
    }
}
