using System;

class Program
{
    static void Main(string[] args)
    {
        int longestCount = 1;
        int currentCount = 1;
        int mostFrequentNumber = numbers[0];

        int[] numbers = new int[30];
        Random random = new Random();

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1, 11);
            Console.Write(numbers[i] + " ");
        }

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] == numbers[i - 1])
            {
                currentCount++;
            }
            else
            {
                if (currentCount > longestCount)
                {
                    longestCount = currentCount;
                    mostFrequentNumber = numbers[i - 1];
                }
                currentCount = 1;             }
        }

        if (currentCount > longestCount)
        {
            longestCount = currentCount;
            mostFrequentNumber = numbers[numbers.Length - 1];
        }

        Console.WriteLine($"Самое длинное повторение: число {mostFrequentNumber}, количество повторений {longestCount}");
        Console.ReadKey();
    }
}