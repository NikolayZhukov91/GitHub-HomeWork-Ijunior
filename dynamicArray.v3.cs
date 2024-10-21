using System;

namespace Dynamic_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isWork = true;
            string userInput;
            int action;
            int[] numbers = new int[0];
            string sum = "sum";
            string exit = "exit";

            while (isWork)
            {
                Console.SetCursorPosition(0, 5);

                Console.WriteLine($"Введите ваше число, или команду суммы - '{sum}' или команту выхода из программы - '{exit}'");
                userInput = Console.ReadLine();

                if (userInput == sum)
                {
                    int sumNumbers = 0;
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        sumNumbers += numbers[i];
                    }
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine($"{sumNumbers} - сумма всех чисел");
                }

                else if (userInput == exit)
                {
                    isWork = false;
                }

                else
                {
                    action = Convert.ToInt32(userInput);
                    int[] tempNumbers;
                    tempNumbers = new int[numbers.Length + 1];

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        tempNumbers[i] = numbers[i];
                    }

                    tempNumbers[tempNumbers.Length - 1] = action;
                    numbers = tempNumbers;
                    Console.SetCursorPosition(0, 1);
                }
                
                for (int i = 0; i < numbers.Length; i++)
                    {
                        Console.Write(numbers[i] + " ");
                    }
                }
            }
        }
    }

