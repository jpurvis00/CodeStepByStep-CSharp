/* Write a method named NumInCommon that accepts two Lists  
 * of integers as parameters and returns the count of how 
 * many unique integers occur in both lists. For example, 
 * if two lists named l1 and l2 contains the values 
 * {3, 7, 3, -1, 2, 3, 7, 2, 15, 15} and {-5, 15, 2, -1, 7, 15, 36} 
 * respectively, your method should return 4 because the elements 
 * -1, 2, 7, and 15 occur in both lists. Use one or more sets as 
 * storage to help you solve this problem. Do not modify the lists passed in.
 */

using Dumpify;

namespace CodeStepByStep_CSharp.Collections.Set
{
    public class NumInCommon
    {
        public static void RunNumInCommon()
        {
            List<int> l1 = new() { 3, 7, 3, -1, 2, 3, 7, 2, 15, 15 };
            List<int> l2 = new() { -5, 15, 2, -1, 7, 15, 36 };
            //HashSet<int> uniqueNumbs = new();

            //foreach (int item in l1)
            //{
            //    if (l2.Contains(item))
            //    {
            //        uniqueNumbs.Add(item);
            //    }
            //}

            //Wrote above first. Found that Intersect finds common 
            //values between the 2 lists. Much easier.
            HashSet<int> uniqueNumbs = new(l1.Intersect(l2));

            uniqueNumbs.DumpConsole();

            Console.WriteLine($"The number of common numbers in both lists is: {uniqueNumbs.Count}");
        }
    }
}
