using System.Collections.Generic;
using System.Linq;

namespace Stacking101.BracketMatching
{
    public class FormulaValidator
    {
        // Question: Check if a string is balanced. Every opening bracket is matched by a closing bracket in a correct position.
        // { [ ( } ] )

        // Example: "()" is balanced
        // Example: "{ ]" is not balanced.
        // Examples: "()[]{}" is balanced.
        // "{([])}" is balanced
        // "{ ( [ ) ] }" is _not_ balanced

        // Input: string, containing the bracket symbols only
        // Output: true or false
        public bool IsBalanced(string input)
        {
            var brackets = BuildBracketMap();
            var openingBraces = new Stack<char>();
            var inputCharacters = input.ToCharArray();

            foreach (char character in inputCharacters)
            {
                if (brackets.ContainsKey(character))
                {
                    openingBraces.Push(character);
                }

                if (brackets.ContainsValue(character))
                {
                    var closingBracket = character;
                    var openingBracket = brackets.FirstOrDefault(x => x.Value == closingBracket).Key;

                    if (openingBraces.Peek() == openingBracket)
                        openingBraces.Pop();
                    else
                        return false;
                }
            }

            return openingBraces.Count == 0;
        }

        private Dictionary<char, char> BuildBracketMap()
        {
            return new Dictionary<char, char>()
            {
                {'[', ']'},
                {'(', ')'},
                {'{', '}'}
            };
        }
    }
}
