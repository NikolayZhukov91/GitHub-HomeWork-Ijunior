using System;

namespace jugglingVariables.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Zhukov";
            string secondName = "Nikolay";
            string support;
            Console.WriteLine($"Первая переменная: {firstName}, вторая переменная: {secondName}.");
            support = firstName;
            firstName = secondName;
            secondName = support;
            Console.WriteLine($"Первая переменная: {firstName}, вторая переменная: {secondName}.");
            Console.ReadKey();
        }
    }
}
