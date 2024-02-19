
//Write a method named NCopies that accepts an array of integers a as a
//parameter and returns a new array a2, with each element value n from
//a replaced by n consecutive copies of the value n at the same relative
//location in the array. For example, if an array named a stores the
//following element values:

//{ 3, 5, 0, 2, 2, -7, 0, 4}
//Then the call of int[] a2 = NCopies(a); should return a new array a2
//containing the following elements. The idea is that the value 3 was
//replaced by three 3s; the 5 was replaced by five 5s; and so on.

//{3, 3, 3, 5, 5, 5, 5, 5, 2, 2, 2, 2, 4, 4, 4, 4}
//Any element whose value is 0 or negative should not be kept in the
//returned array (as with 0 and -7 above).

//The array you return must have a length that is exactly long enough
//to fit its elements. For example, the result array a2 above contains
//3 + 5 + 2 + 2 + 4 = 16 total elements, so the returned array's length
//must be exactly 16 in that case.

//Constraints: In solving this problem, you must create a single new
//array to be returned, but aside from that, do not create any other
//data structures such as temporary arrays or strings. You may use as
//many simple variables (such as ints) as you likeI.

namespace CodeStepByStep_CSharp.Arrays
{
    public static class NCopies
    {
        public static void RunNCopies(int[] array)
        {
            int nCopiesArrayLength = GetNCopiesArrayLength(array);
            int[] nCopiesArray = new int[nCopiesArrayLength];

            nCopiesArray = PopulateArray(array, nCopiesArray);

            DisplayNewArray(nCopiesArray);
        }
        private static int GetNCopiesArrayLength(int[] array)
        {
            int nCopiesArrayLength = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    nCopiesArrayLength += array[i];
                }
            }

            return nCopiesArrayLength;
        }

        private static int[] PopulateArray(int[] array, int[] nCopiesArray)
        {
           int newArrayIndex = 0;

           for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    for(int j = 0; j < array[i]; j++)
                    {
                        nCopiesArray[newArrayIndex] = array[i]; 
                        newArrayIndex++;
                    }
                }
            }

           return nCopiesArray;
        }
        
        private static void DisplayNewArray(int[] nCopiesArray)
        {
            for (int i = 0; i < nCopiesArray.Length; i++)
            {
                Console.Write(nCopiesArray[i] + " ");
            }
        }
    }
}
