using Stacking101.BracketMatching;
using System;

namespace Stacking101
{
    class Program
    {
        static void Main(string[] args)
        {
            var testData = new string[] {
                "(x + y) - ((z * y) + x)",
                "{(1 / 2) + (y / z)} - ([g + z]) - (x + y)",
                "[x + y] - (5 * x)",
                "(x + 3]",
                "{(y + z)]",
                "(x + y) + [g(5])]"
            };
            var formulaValidator = new FormulaValidator();

            foreach(var equation in testData)
            {
                Console.WriteLine(
                    string.Format("{0} {1}", equation, formulaValidator.IsBalanced(equation))
                );
            }

            Console.ReadKey();
        }
    }
}
