
//Write a method named Split that accepts an array of integers as a parameter
//and returns a new array twice as large as the original, replacing every
//integer from the original array with a pair of integers, each half the original.
//If a number in the original array is odd, then the first number in the new pair
//should be one higher than the second so that the sum equals the original number.
//For example, if a variable named a refers to an array storing the
//values {18, 7, 4, 24, 11}, the call of Split(a) should return a new array
//containing {9, 9, 4, 3, 2, 2, 12, 12, 6, 5}. (The number 18 is Split into the
//pair 9, 9, the number 7 is Split into 4, 3, the number 4 is Split into 2, 2,
//the number 24 is Split into 12, 12 and the number 11 is Split into 6, 5.)

namespace CodeStepByStep_CSharp.Arrays
{
    public class Split
    {
        public static void RunSplit(int[] list)
        {
            int[] newArray = CreateNewArray(list.Length);
            newArray = PopulateArray(newArray, list);
            DisplayArray(newArray, list);
        }

        private static void DisplayArray(int[] newArray, int[] originalArray)
        {
            Console.Write($"Original Array: ");
            
            for(int i = 0; i < originalArray.Length; i++)
            {
                Console.Write($"{originalArray[i]} ");
            }
            
            Console.Write($"\nSplit Array: ");
            
            for(int i = 0; i < newArray.Length; i++)
            {
                Console.Write($"{newArray[i]} ");
            }
        }

        private static int[] PopulateArray(int[] newArray, int[] list)
        {
            int newArrayIndex = 0;

            for(int i = 0; i < list.Length; i++)
            {
                if (list[i] % 2 == 0)
                {
                    newArrayIndex = StoreNewValues(newArrayIndex, newArray, list, i, true);
                }
                else
                {
                    newArrayIndex = StoreNewValues(newArrayIndex, newArray, list, i, false);
                }
            }

            return newArray;
        }

        private static int StoreNewValues(int newArrayIndex, int[] newArray, int[] list, int index, bool isEven)
        {
            int result = list[index] / 2;
            
            if (isEven == true)
            {
                newArray[newArrayIndex] = result;
            }
            else
            {
                newArray[newArrayIndex] = result + 1;
            }

            newArray[newArrayIndex + 1] = result;
            newArrayIndex = newArrayIndex + 2;

            return newArrayIndex;
        }

        private static int[] CreateNewArray(int length)
        {
            int[] newArray = new int[length * 2];

            return newArray;
        }
    }
}
