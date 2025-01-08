/* Write a method named RemoveDuplicates that accepts as a 
 * parameter a List of integers, and modifies it by removing 
 * any duplicates. Note that the elements of the list are 
 * not in any particular order, so the duplicates might not 
 * occur consecutively. You should retain the original 
 * relative order of the elements. Use a set as auxiliary 
 * storage to help you solve this problem. For example, 
 * if a list named l stores {4, 0, 2, 9, 4, 7, 2, 0, 0, 9, 6, 6}, 
 * the call of RemoveDuplicates(l); should modify it to 
 * store {4, 0, 2, 9, 7, 6}.
 */

using Dumpify;

namespace CodeStepByStep_CSharp.Collections.Set
{
    public class RemoveDuplicates
    {
        public static void RunRemoveDuplicates()
        {
            List<int> l = new() { 4, 0, 2, 9, 4, 7, 2, 0, 0, 9, 6, 6 };

            //Easy way
            HashSet<int> uniqueNumbers = new(l.Distinct());

            uniqueNumbers.DumpConsole();

            HashSet<int> uniqueNumbers2 = new();

            foreach (int numb in l)
            {
                if (!uniqueNumbers2.Contains(numb))
                {
                    uniqueNumbers2.Add(numb);
                }
            }

            uniqueNumbers2.DumpConsole();
        }
    }
}
