
/*Write a method named Cumulative that accepts as a parameter a List of integers, and modifies it so that each element contains the Cumulative sum of the elements up through that index. For example, if the list passed contains {1, 1, 2, 3, 5}, your method should modify it to store {1, 2, 4, 7, 12}.
 */

using Dumpify;

namespace CodeStepByStep_CSharp.Collections.List
{
    public class Cumulative
    {
        public static void RunCumulative()
        {
            List<int> values = new() { 1, 1, 2, 3, 5 };

            for (int i = 0; i < values.Count - 1; i++)
            {
                int sum = values[i] + values[i + 1];

                values[i + 1] = sum;
            }

            values.DumpConsole();
        }
    }
}
