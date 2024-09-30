using System;

namespace jugglingVariables.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Zhukov";
            string secondName = "Nikolay";
            string tempName;
            Console.WriteLine($"Первая переменная: {firstName}, вторая переменная: {secondName}.");
            tempName = firstName;
            firstName = secondName;
            secondName = tempName;
            Console.WriteLine($"Первая переменная: {firstName}, вторая переменная: {secondName}.");
            Console.ReadKey();
        }
    }
}
