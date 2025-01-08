/* Write a method named UnionSets that accepts as a parameter a 
 * HashSet of SortedSets of integers, and returns a SortedSet of 
 * integers representing the union of all of the sets of ints. 
 * (A union is the combination of everything in each set.) 
 * For example, calling your method on the following set of sets: 
 * {{1, 3}, {2, 3, 4, 5}, {3, 5, 6, 7}, {42}} 
 *
 * Should cause the following set of integers to be returned: 
 * {1, 2, 3, 4, 5, 6, 7, 42}
 *
 */

using Dumpify;

namespace CodeStepByStep_CSharp.Collections.Set
{
    public class UnionSets
    {
        public static void RunUnionSets()
        {
            HashSet<int> set1 = new() { 1, 3 };
            HashSet<int> set2 = new() { 2, 3, 4, 5 };
            HashSet<int> set3 = new() { 3, 5, 6, 7 };
            HashSet<int> set4 = new() { 42 };
            HashSet<int> completeUnion = new();

            /* without built in method for sets
            CreateUnion(set1, completeUnion);
            completeUnion.DumpConsole();

            CreateUnion(set2, completeUnion);
            completeUnion.DumpConsole();

            CreateUnion(set3, completeUnion);
            completeUnion.DumpConsole();

            CreateUnion(set4, completeUnion);
            completeUnion.OrderBy(x => x).DumpConsole();
            */

            //with built in method for set
            set1.UnionWith(set2);
            set1.UnionWith(set3);
            set1.UnionWith(set4);
            set1.OrderBy(static x => x).DumpConsole();
        }

        private static void CreateUnion(HashSet<int> set, HashSet<int> complete)
        {
            foreach (int item in set)
            {
                if (!complete.Contains(item))
                {
                    complete.Add(item);
                }
            }
        }
    }
}
