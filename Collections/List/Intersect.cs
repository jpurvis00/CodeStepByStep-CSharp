//Write a method named Intersect that accepts references to 
//two sorted List of integers as parameters and returns a new 
//list that contains only the elements that are found in both 
//lists. For example, if list v1 and v2 store:
//
//{1, 4, 8, 9, 11, 15, 17, 28, 41, 59}
//{4, 7, 11, 17, 19, 20, 23, 28, 37, 59, 81}
//Then the call of Intersect(v1, v2) returns the list: 
//{4, 11, 17, 28, 59} Note that you can assume that both 
//lists passed store their elements in sorted order. Do not 
//modify the two lists passed in as parameters.

using Dumpify;

namespace CodeStepByStep_CSharp.Collections.List
{
    public class IntersectLists
    {
        public static void RunIntersect()
        {
            List<int> v1 = new() { 1, 4, 8, 9, 11, 15, 17, 28, 41, 59 };
            List<int> v2 = new() { 4, 7, 11, 17, 19, 20, 23, 28, 37, 59, 81 };
            List<int> results = new();

            foreach (int numb1 in v1)
            {
                foreach (int numb2 in v2)
                {
                    if (numb1 < numb2)
                    {
                        break;
                    }

                    if (numb1 == numb2)
                    {
                        results.Add(numb1);
                        break;
                    }
                }
            }
            results.DumpConsole();
        }
    }
}
