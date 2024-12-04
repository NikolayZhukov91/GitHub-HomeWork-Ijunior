using System;

namespace Parenthesis_expression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string parenthesisExpression = "((()))";
            char leftBrackets = '(';
            char rightBrackets = ')';
            int currentDepth = 0;
            int maxDepth = 0;
            bool isValidDepth = true;

            for (int i = 0; i < parenthesisExpression.Length; i++)
            {
                if (parenthesisExpression[i] == leftBrackets)
                {
                    currentDepth++;  

                    if (currentDepth > maxDepth)
                    {
                        maxDepth = currentDepth;
                    }
                }
                else if (parenthesisExpression[i] == rightBrackets)
                {
                    currentDepth--;  
                    if (currentDepth < 0)
                    {
                        isValidDepth = false;  
                        break;            
                    }
                }
            }

            if (currentDepth != 0)
            {
                isValidDepth = false;
            }

            if (isValidDepth)
            {
                Console.WriteLine($"Строка корректная. Глубина = {maxDepth}.");
            }
            else
            {
                Console.WriteLine("Строка некорректная");
            }

            Console.ReadKey();
        }
    }
}
