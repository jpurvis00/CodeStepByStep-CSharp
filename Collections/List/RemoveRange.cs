//Write a method named RemoveRange that accepts a List of integers and two 
//integer values min and max as parameters and removes all elements values 
//in the range min through max (inclusive). For example, if a List named 
//list stores [7, 9, 4, 2, 7, 7, 5, 3, 5, 1, 7, 8, 6, 7], the call of 
//RemoveRange(list, 5, 7); should change the list to store [9, 4, 2, 3, 1, 8].

using Dumpify;

namespace CodeStepByStep_CSharp.Collections.List
{
    public class RemoveRange
    {
        public static void RunRemoveRange()
        {
            List<int> numbers = new() { 7, 9, 4, 2, 7, 7, 5, 3, 5, 1, 7, 8, 6, 7, 4 };
            int min = 5;
            int max = 7;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] >= min && numbers[i] <= max)
                {
                    numbers.RemoveAt(i);
                    i--;
                }
            }

            numbers.DumpConsole();
        }
    }
}
