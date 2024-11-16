/* Write a console program named UniqueNames that asks the user 
 * for a list of names (one per line) until the user enters a 
 * blank line (i.e., just presses Enter when asked for a name). 
 * At that point the program should print out the list of names 
 * entered, where each name is listed only once (i.e., uniquely) 
 * no matter how many times the user entered the name in the program. 
 * For example, your program should behave as follows:
 * Enter name: Alice
 * Enter name: Bob
 * Enter name: Alice
 * Enter name: Alice
 * Enter name: Alice
 * Enter name: Bob
 * Unique name list contains: Alice Bob
 */

using Dumpify;

namespace CodeStepByStep_CSharp.Collections.List
{
    public class UniqueNames
    {
        public static void RunUniqueNames()
        {
            string input = string.Empty;
            HashSet<string> uniqueNames = new();

            do
            {
                Console.Write("Enter name: ");
                input = Console.ReadLine();

                uniqueNames.Add(input);
            } while (!input.Equals(""));

            uniqueNames.Remove("");
            uniqueNames.DumpConsole();
        }
    }
}
