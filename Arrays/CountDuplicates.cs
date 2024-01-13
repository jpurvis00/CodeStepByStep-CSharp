
namespace CodeStepByStep_CSharp.Arrays
{
    //Write a method named CountDuplicates that accepts an array of integers
    //as a parameter and that returns the number of duplicate values in the array.
    //A duplicate value is a value that also occurs earlier in the array.
    //For example, if an array named a contains[1, 4, 2, 4, 7, 1, 1, 9, 2, 3, 4, 1],
    //then the call of CountDuplicates(a) should return 6 because there are three
    //duplicates of the value 1, one duplicate of the value 2, and two duplicates of the value 4.

    //Constraints: The array could be empty or could contain only a single element;
    //in such cases, your method should return 0. Do not modify the contents of the array.

    internal class CountDuplicates
    {
        public static void RunCountDuplicate()
        {
            int[] a1 = { 1, 4, 2, 4, 7, 1, 1, 9, 2, 3, 4, 1 };
            List<int> checkedNumbers = new List<int>();

            int consecuctiveCount = 0;

            for (int i = 0; i < a1.Length; i++)
            {
                if (checkedNumbers.Contains(a1[i]))
                {
                    break;
                }

                for (int j = i + 1; j < a1.Length; j++)
                {
                    if (a1[j] == a1[i])
                    {
                        consecuctiveCount++;
                    }
                }
                checkedNumbers.Add(a1[i]);
            }

            Console.WriteLine($"Number of duplicate #'s: {consecuctiveCount}");
        }
    }
}
