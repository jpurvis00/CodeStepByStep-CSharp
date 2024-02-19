
//Write a method named Mean that accepts an array of real numbers as a
//parameter and returns the arithmetic mean (average) of the numbers in
//the array as a real number. For example, if the array passed contains
//{2.0, 4.5, 6.5, 1.0}, your method should return 3.5. If the array is
//empty, return 0.0. Do not modify the array that is passed in.

namespace CodeStepByStep_CSharp.Arrays
{
    public class Mean
    {
        public static double RunMean(double[] array)
        {
            double sum = 0;

            if (array.Length == 0)
            {
                return 0.0;
            }

            for(int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum / array.Length;
        }
    }
}
