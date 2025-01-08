/* Write a method named NumUniqueValues that accepts a List of integers 
 * as a parameter and returns the number of unique integer values in the list. 
 * For example, if a list named l contains the values 
 * {3, 7, 3, -1, 2, 3, 7, 2, 15, 15}, the call of NumUniqueValues(l) 
 * should return 5. If passed the empty list, you should return 0. 
 * Use a set as auxiliary storage to help you solve this problem. 
 * Do not modify the list passed in.
 */

using Dumpify;

namespace CodeStepByStep_CSharp.Collections.Set
{
    public class NumUniqueValues
    {
        public static void RunNumUniqueValues()
        {
            //List<int> l = new() { 3, 7, 3, -1, 2, 3, 7, 2, 15, 15 };
            List<int> l = new();

            HashSet<int> uniqueNumbs = new(l.Distinct());

            uniqueNumbs.DumpConsole();

            Console.WriteLine($"The number of unique values is {uniqueNumbs.Count}");
        }
    }
}
