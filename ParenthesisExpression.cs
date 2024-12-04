using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Parenthesis_expression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] parenthesisExpression = new string[] { "(", "(", "(", "(", ")", ")", ")", ")", };
            int numberRightBrackets = 0;
            int numberLeftBrackets = 0;
            int currentDepth = 0;

            for (int i = 0; i < parenthesisExpression.Length; i++)
            {
                if (parenthesisExpression[i] == ")")
                {
                    numberRightBrackets ++;
                }
                else
                {
                    numberLeftBrackets ++;
                }
            }

            currentDepth += numberLeftBrackets;

            if (numberRightBrackets == numberLeftBrackets)
            {
                Console.WriteLine($"Строка корректная. Глубина = {currentDepth}.");
            }
            else
            {
                Console.WriteLine("Строка не корректная");
            }

            Console.ReadKey();
        }
    }
}
