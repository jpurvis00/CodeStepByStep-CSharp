/* Write a method named RemoveRange that accepts three parameters:  
 * a HashSet of integers, a minimum value, and a maximum value. 
 * The method should remove any values from the set that are between 
 * that minimum and maximum value, inclusive. For example, if a set 
 * named s contains {3, 17, -1, 4, 9, 2, 14}, the call of RemoveRange(s, 1, 10); 
 * should modify s to store {17, -1, 14}.
 */

using System.Collections.Generic;
using Dumpify;

namespace CodeStepByStep_CSharp.Collections.Set
{
    public class RemoveRange
    {
        public static void RunRemoveRange()
        {
            HashSet<int> numbs = new() { 3, 17, -1, 4, 9, 2, 14 };
            numbs.DumpConsole();

            Remove(numbs, 1, 10);

            numbs.DumpConsole();
        }

        private static void Remove(HashSet<int> numbs, int numb1, int numb2)
        {
            for (int i = numb1; i < numb2; i++)
            {
                if (numbs.Contains(i))
                {
                    numbs.Remove(i);
                }
            }
        }
    }
}
