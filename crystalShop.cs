using System;

namespace crystalShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerGold;
            int playerCrystals;
            int costOfCrystals = 10;
            int numberOfCrystals;
            Console.WriteLine($"Сколько у вас золота?");
            playerGold = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"1 кристалл стоит: {costOfCrystals} золота.");
            Console.WriteLine("Сколько кристаллов вы хотите купить?");
            numberOfCrystals = Convert.ToInt32(Console.ReadLine());
            playerGold = playerGold - numberOfCrystals*costOfCrystals;
            playerCrystals = numberOfCrystals;
            Console.WriteLine($"У вас: {playerGold} золота и {playerCrystals} кристаллов");
            Console.ReadKey();
        }
    }
}
