

//Write a method named FindMedian that accepts an array of integers as its
//parameter and returns the median of the numbers in the array. The
//median is the number that will appear in the middle if you arrange
//the elements in order. Assume that the array is of odd size (so that
//one sole element constitutes the median) and that the numbers in the
//array are between 0 and 99 inclusive.

//For example, the median of {5, 2, 4, 17, 55, 4, 3, 26, 18, 2, 17} is 5,
//and the median of {42, 37, 1, 97, 1, 2, 7, 42, 3, 25, 89, 15, 10, 29, 27} is 25.

namespace CodeStepByStep_CSharp.Arrays
{
    internal class FindMedian
    {
        public static int RunFindMedian(int[] a1)
        {
            int output = 0;

            List<int> sortedArray = a1.ToList();
            sortedArray.Sort();

            output = sortedArray.ElementAt((int)Math.Ceiling(sortedArray.Count / 2.0) - 1);
            
            return output;
        }
    }
}
