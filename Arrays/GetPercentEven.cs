//Write a method named GetPercentEven that accepts an array of
//integers as a parameter and returns the percentage of the
//integers in the array that are even numbers. For example, if an
//array a stores {6, 4, 9, 11, 5}, then your method should return 40.0
//representing 40% even numbers. If the array contains no even elements
//or is empty, return 0.0. Do not modify the array passed in. 

namespace CodeStepByStep_CSharp.Arrays
{
    internal class GetPercentEven
    {
        public static double RunGetPercentEven(int[] a1)
        {
            double evenCount = 0;

            for(int i = 0; i < a1.Length; i++)
            {
                if (a1[i] % 2 == 0)
                {
                    evenCount++;
                }
            }

            return (evenCount / a1.Length) * 100;
        }
    }
}
