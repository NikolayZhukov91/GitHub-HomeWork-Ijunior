using System;

namespace Dynamic_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int CommandSum = int.MinValue;
            const int CommandExit = int.MaxValue;
            bool isWork = true;
            string userInput;
            int action;
            int sum = 0;
            int[] dinamicArray= new int [0];
            int[] tempDinamicArray;

            while (isWork)
            {
                Console.SetCursorPosition(0, 5);
                Console.WriteLine("Введите ваше число, или команды 'sum' или 'exit'");
                userInput = Console.ReadLine();
                if (userInput == "sum")
                {
                    action = CommandSum;
                }
                else if (userInput == "exit")
                {
                    action = CommandExit;
                }
                else 
                { 
                    action = Convert.ToInt32(userInput);
                }

                switch (action)
                {
                    case CommandSum:
                        
                        for (int i = 0; i < dinamicArray.Length; i++)
                        {
                            sum += dinamicArray[i];
                        }
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine($"{sum} - сумма всех чисел");
                        break;
                    case CommandExit:
                        isWork = false;
                        break;
                    default:
                        tempDinamicArray = new int[dinamicArray.Length + 1];
                        
                        for (int i = 0; i < dinamicArray.Length; i++)
                        {
                            tempDinamicArray[i] = dinamicArray[i];
                        }
                        tempDinamicArray[tempDinamicArray.Length - 1] = action;
                        dinamicArray = tempDinamicArray;
                        Console.SetCursorPosition(0, 1);

                        for (int i = 0;i < dinamicArray.Length; i++)
                        {
                            Console.Write(tempDinamicArray[i] + " ");
                        }
                        break;
                }
                
            }
            
        }
    }
}
