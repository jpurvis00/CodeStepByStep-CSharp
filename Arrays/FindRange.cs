
//Write a method named FindRange that accepts an array of integers as a
//parameter and returns the range of values contained in the array,
//which is equal to one more than the difference between its largest
//and smallest element. For example, if the largest element is 17 and
//the smallest is 6, the range is 12. If the largest and smallest
//values are the same, the range is 1.

//Constraints: You may assume that the array contains at least one
//element (that its length is at least 1). You should not modify the contents of the array.

namespace CodeStepByStep_CSharp.Arrays
{
    internal class FindRange
    {
        public static int RunFindRange(int[] a1)
        {
            int smallest = a1[0];
            int largest = a1[0];

            for (int i = 0; i < a1.Length; i++)
            {
                if (a1[i] < smallest)
                {
                    smallest = a1[i];
                }

                if (a1[i] > largest)
                {
                    largest = a1[i];
                }
            }

            return (largest - smallest) + 1;



            //int smallest = a1[0];
            //int largest = a1[0]; 

            //for (int i = 0; i < a1.Length; i++)
            //{
            //    if(a1[i] < smallest)
            //    {
            //        smallest = a1[i];
            //    }

            //    if(a1[i] > largest)
            //    {
            //        largest = a1[i];
            //    }
            //}

            //return largest - smallest + 1;
        }
    }
}
