using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magicExchange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandGoldForCrystals = "1";
            const string CommandGoldForSilver = "2";
            const string CommandCrystalsForGold = "3";
            const string CommandCrystalsForSilver = "4";
            const string CommandSilverForGold = "5";
            const string CommandSilverForCrystals = "6";
            const string CommandExit = "7";

            float goldInWallet;
            float silverInWallet;
            float crystalsInWallet;

            int goldToCrystals = 2; int goldToSilver = 3;
            int silverToCrystals = 4; int silverToGold = 5;
            int crystalsToGold = 6; int crystalToSilver = 7;

            float exchangeCurrencyCount;
            string desiredOperation;

            Console.WriteLine("Приветствую тебя, Маг! Это обменник");

            Console.WriteLine("Сколько у вас золота?");
            goldInWallet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сколько у вас серебра?");
            silverInWallet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сколько у вас кристалов?");
            crystalsInWallet = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите необходимую операцию:");
            Console.WriteLine($"{CommandGoldForCrystals} - обмен золота на кристалы.");
            Console.WriteLine($"{CommandGoldForSilver} - обмен золота на серебро");
            Console.WriteLine($"{CommandCrystalsForGold} - обмен кристаллов на золото");
            Console.WriteLine($"{CommandCrystalsForSilver} - обмен кристаллов на серебро");
            Console.WriteLine($"{CommandSilverForGold} - обмен серебро на золото");
            Console.WriteLine($"{CommandSilverForCrystals} - обмен серебро на кристаллы");
            Console.WriteLine($"{CommandExit} - Выход из обменника");
            Console.WriteLine($"Ваш команда:");
            desiredOperation = Console.ReadLine();

            bool isWork =true;
            while (isWork)
            {
                switch (desiredOperation)
                {
                    case CommandGoldForCrystals:
                        Console.WriteLine("Обмен золота на кристаллы:");
                        Console.WriteLine("Сколько вы хотите обменять?");
                        exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());

                        if (goldInWallet >= exchangeCurrencyCount)
                        {
                            goldInWallet -= exchangeCurrencyCount;
                            crystalsInWallet += exchangeCurrencyCount * goldToCrystals;
                            Console.WriteLine($"Ваш баланс: {crystalsInWallet} - кристаллов, {goldInWallet} - золота, {silverInWallet} - серебра.");
                            Console.WriteLine("Ваш команда:");
                            desiredOperation = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Недопустимое количество золота.");
                        }

                        break;

                    case CommandGoldForSilver:
                        Console.WriteLine("Обмен золота на серебро:");
                        Console.WriteLine("Сколько вы хотите обменять?");
                        exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());

                        if (goldInWallet >= exchangeCurrencyCount)
                        {
                            goldInWallet -= exchangeCurrencyCount;
                            silverInWallet += exchangeCurrencyCount * goldToSilver;
                            Console.WriteLine($"Ваш баланс: {crystalsInWallet} - кристаллов, {goldInWallet} - золота, {silverInWallet} - серебра.");
                            Console.WriteLine("Ваш команда:");
                            desiredOperation = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Недопустимое количество золота.");
                        }

                        break;

                    case CommandCrystalsForGold:
                        Console.WriteLine("Обмен кристаллов на золото:");
                        Console.WriteLine("Сколько вы хотите обменять?");
                        exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());

                        if (crystalsInWallet >= exchangeCurrencyCount)
                        {
                            crystalsInWallet -= exchangeCurrencyCount;
                            goldInWallet += exchangeCurrencyCount * crystalsToGold;
                            Console.WriteLine($"Ваш баланс: {crystalsInWallet} - кристаллов, {goldInWallet} - золота, {silverInWallet} - серебра.");
                            Console.WriteLine("Ваш команда:");
                            desiredOperation = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Недопустимое количество кристаллов.");
                        }

                        break;

                    case CommandCrystalsForSilver:
                        Console.WriteLine("Обмен кристаллов на серебро:");
                        Console.WriteLine("Сколько вы хотите обменять?");
                        exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());

                        if (crystalsInWallet >= exchangeCurrencyCount)
                        {
                            crystalsInWallet -= exchangeCurrencyCount;
                            silverInWallet += exchangeCurrencyCount * crystalToSilver;
                            Console.WriteLine($"Ваш баланс: {crystalsInWallet} - кристаллов, {goldInWallet} - золота, {silverInWallet} - серебра.");
                            Console.WriteLine("Ваш команда:");
                            desiredOperation = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Недопустимое количество кристаллов.");
                        }

                        break;

                    case CommandSilverForGold:
                        Console.WriteLine("Обмен серебро на золото:");
                        Console.WriteLine("Сколько вы хотите обменять?");
                        exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());

                        if (silverInWallet >= exchangeCurrencyCount)
                        {
                            silverInWallet -= exchangeCurrencyCount;
                            goldInWallet += exchangeCurrencyCount * silverToGold;
                            Console.WriteLine($"Ваш баланс: {crystalsInWallet} - кристаллов, {goldInWallet} - золота, {silverInWallet} - серебра.");
                            Console.WriteLine("Ваш команда:");
                            desiredOperation = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Недопустимое количество серебра.");
                        }

                        break;

                    case CommandSilverForCrystals:
                        Console.WriteLine("Обмен серебро на кристаллы:");
                        Console.WriteLine("Сколько вы хотите обменять?");
                        exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());

                        if (silverInWallet >= exchangeCurrencyCount)
                        {
                            silverInWallet -= exchangeCurrencyCount;
                            crystalsInWallet += exchangeCurrencyCount * silverToCrystals;
                            Console.WriteLine($"Ваш баланс: {crystalsInWallet} - кристаллов, {goldInWallet} - золота, {silverInWallet} - серебра.");
                            Console.WriteLine("Ваш команда:");
                            desiredOperation = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Недопустимое количество кристалов.");
                        }

                        break;

                    case CommandExit:
                        isWork = false;
                        break;

                    default:
                        Console.WriteLine("Выбранна не верная операция");
                        break;
                }
            }
        }
    }
}
