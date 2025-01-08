/* Write a method named Twice that accepts as a parameter a 
 * list of integers and returns a SortedSet containing all the 
 * numbers in the list that appear exactly twice. For example, 
 * if a list variable v stores {1, 3, 1, 4, 3, 7, -2, 0, 7, -2, -2, 1}, 
 * the call of Twice(v) should return the set {3, 7}.
 * If you want an extra challenge: Use only sets as auxiliary storage.
*/

using Dumpify;

namespace CodeStepByStep_CSharp.Collections.Set
{
    public class Twice
    {
        public static void RunTwice()
        {
            List<int> numbs = new() { 1, 3, 1, 4, 3, 7, -2, 0, 7, -2, -2, 1 };
            HashSet<int> temp = new();
            HashSet<int> numbsTwice = new();

            foreach (int numb in numbs)
            {
                if (!temp.Contains(numb))
                {
                    temp.Add(numb);
                }
                else
                {
                    numbsTwice.Add(numb);
                }
            }

            numbsTwice.OrderBy(x => x).DumpConsole();
        }
    }
}
