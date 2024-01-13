

//Write a method named CountUnique that accepts an array of integers as a
//parameter and returns a count of the number of unique values that occur in the array.
//If the array contains multiple occurrences of the same element value, only one of
//those occurrences should count toward your total. For example, if an array named numbers
//stores {7, 7, 2, 2, 1, 2, 2, 7}, the call of CountUnique(numbers) should
//return 3 because there are 3 unique values: 7, 2, and 1.

//Constraints: In solving this problem, do not create any other data structures
//such as arrays, strings, etc., though you may create as many simple variables
//(e.g. int, double) as you like. Do not modify the array passed to your method
//as the parameter, such as by sorting or rearranging its element values.

using System;

namespace CodeStepByStep_CSharp.Arrays
{
    internal class CountUnique
    {
        public static int CountUniqueNumbers(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                return 0; 
            }

            int uniqueCount = 1; 

            for (int i = 1; i < array.Length; i++)
            {
                bool isUnique = true;

                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        isUnique = false;
                        break;
                    }
                }

                if (isUnique)
                {
                    uniqueCount++;
                }
            }

            return uniqueCount;
        }
    }
}
