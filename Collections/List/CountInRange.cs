
/* Write a method named CountInRange that accepts three parameters: a List of integers, a minimum and maximum integer, and returns the number of elements in the list within that range inclusive. For example, if the list v contains {28, 1, 17, 4, 41, 9, 59, 8, 31, 30, 25}, the call of CountInRange(v, 10, 30) should return 4. If the list is empty, return 0. Do not modify the list that is passed in.
 */

using Dumpify;

namespace CodeStepByStep_CSharp.Collections.List
{
    public class CountInRange
    {
        public static void RunCountInRange()
        {
            List<int> v = new() { 28, 1, 17, 4, 41, 9, 59, 8, 31, 30, 25 };

            int value = FindRange(v, 1, 20);

            Console.WriteLine($"Value: {value}");
        }

        private static int FindRange(List<int> v1, int smallest, int largest)
        {
            int count = 0;

            if (v1.Count == 0)
            {
                return 0;
            }

            foreach (int v in v1)
            {
                if (v >= smallest && v <= largest)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
