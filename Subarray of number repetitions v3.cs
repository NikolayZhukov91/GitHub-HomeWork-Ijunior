using System;

class Program
{
    static void Main(string[] args)
    {
        int longestCount = 1;
        int currentCount = 1;
        int lowerBound = 1;
        int upperBound = 11;
        int numberOne = 1;
        int[] numbers = new int[30];
        Random random = new Random();

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(lowerBound, upperBound);
            Console.Write(numbers[i] + " ");
        }
        
        Console.WriteLine();
        int mostFrequentNumber = numbers[0];

        for (int i = numberOne; i < numbers.Length; i++)
        {
            if (numbers[i] == numbers[i - numberOne])
            {
                currentCount++;
                if (currentCount > longestCount)
                {
                    longestCount = currentCount;
                    mostFrequentNumber = numbers[i - numberOne];
                }
            }
            else
            {
                currentCount = numberOne;             
            }
        }
        
        Console.WriteLine($"Самое длинное повторение: число {mostFrequentNumber}, количество повторений {longestCount}");
        Console.ReadKey();
    }
}
