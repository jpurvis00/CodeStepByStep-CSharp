
//Write a method named MaxValue that accepts an array of integers as a parameter and
//returns the maximum value in the array. For example, if an array named a passed
//stores {17, 7, -1, 26, 3, 9}, the call of MaxValue(a) should return 26. You may
//assume that the array contains at least one element. Your method should not
//modify the elements of the array.

namespace CodeStepByStep_CSharp.Arrays
{
    public class MaxValue
    {
        public static int RunMaxValue(int[] array)
        {
            int maxValue = array[0];

            for(int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }
            }

            return maxValue;
        }
    }
}
