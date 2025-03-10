/* Write a method named CheckBalance that accepts a string of 
 * source code and uses a Stack to check whether the braces/parentheses  
 * are balanced. Every ( or { must be closed by a } or ) in the opposite 
 * order. Return the index at which an imbalance occurs, or 
 * -1 if the string is balanced. If any ( or { are never closed, 
 *  return the string's length. 
 *
 *  Here are some example calls:
 *
 *  index   0123456789012345678901234567890 
 *
 *  CheckBalance("if (a(4) > 9) { foo(a(2)); }")      // returns -1 because balanced 
 *  CheckBalance("for (i=0;i<a(3};i++) { foo{); )")   // returns 14 because } out of order 
 *  CheckBalance("while (true) foo(); }{ ()")         // returns 20 because } doesn't match any { 
 *  CheckBalance("if (x) {")                          // returns 8 because { is never closed 
 *
 *  Constraints: Use a single stack as auxiliary storage. 
 */

using Dumpify;

namespace CodeStepByStep_CSharp.Collections.StackAndQueue
{
    public class CheckBalance
    {
        public static void RunCheckBalance()
        {
            Stack<char> stack = new();
            //string formula = "if (a(4) > 9) { foo(a(2)); }";
            //string formula = "for (i=0;i<a(3};i++) { foo{); )";
            //string formula = "while (true) foo(); }{ ()";
            string formula = "if (x[a]) {";
            Console.WriteLine($"Statement we are checking: {formula}");
            var result = CheckBalances(stack, formula);

            if (result.Item1 == -1)
            {
                Console.WriteLine("All opening/closing operators were present.");
            }
            else if (result.Item1 == 0)
            {
                Console.WriteLine($"The error occurred on the {result.Item1} character({result.Item2}) in the string.");
            }
            else if (result.Item1 == 1)
            {
                Console.WriteLine($"The error occurred on the {result.Item1}st character({result.Item2}) in the string.");
            }
            else
            {
                Console.WriteLine($"The error occurred on the {result.Item1}th character({result.Item2}) in the string.");
            }

            Console.WriteLine("Stack looks like the following after checking statement.");
            stack.DumpConsole();
        }

        private static (int, char) CheckBalances(Stack<char> stack, string sourceCode)
        {
            Console.WriteLine($"length: {sourceCode.Length}");
            int i = 0;

            foreach (char c in sourceCode)
            {
                //push opening operator onto stac
                if (c.Equals('(') || c.Equals('{') || c.Equals('['))
                {
                    stack.Push(c);
                }

                //if char is a closing operator
                if (c.Equals('}') || c.Equals(')') || c.Equals(']'))
                {
                    //the stack is empty, meaning there was no matching opening operator
                    if (stack.Count == 0)
                    {
                        return (i, c);
                    }

                    char openiningChar = stack.Pop();

                    //make sure opening/closing matches ()
                    if (openiningChar.Equals('(') && c.Equals(')'))
                    {
                        i++;
                        continue;
                    }

                    //make sure opening/closing matches {} 
                    if (openiningChar.Equals('{') && c.Equals('}'))
                    {
                        i++;
                        continue;
                    }

                    //make sure opening/closing matches [] 
                    if (openiningChar.Equals('[') && c.Equals(']'))
                    {
                        i++;
                        continue;
                    }

                    return (i, c);
                }

                i++;
            }

            //nothing is left in the stack meaning all opening operators found
            //a closing operator
            if (stack.Count == 0)
            {
                return (-1, ' ');
            }
            else
            //stack still has something in it and we have gone through the entire
            //string. Return the lenght of the string
            {
                return (i, ' ');
            }
        }
    }
}
