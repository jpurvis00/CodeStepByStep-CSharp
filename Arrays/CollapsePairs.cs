using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace CodeStepByStep_CSharp.Arrays
{
    //Write a method named CollapsePairs that accepts an array of integers as a parameter
    //and modifies the array so that each of its pairs of neighboring integers(such as the
    //pair at indexes 0-1, and the pair at indexes 2-3, etc.) are combined into a single sum
    //of that pair.The sum will be stored at the even index(0,2,4, etc.) if the sum is even
    //and at the odd index(1,3,5, etc.) if the sum is odd.The other index of the pair will
    //change to 0.

    //For example, if an array named a stores the values {7, 2, 8, 9, 4, 22, 7, 1, 9, 10},
    //then the call of CollapsePairs(a); should modify the array to contain the values
    //{0, 9, 0, 17, 26, 0, 8, 0, 0, 19}. The first pair from the original array is collapsed
    //into 9 (7 + 2), which is stored at the odd index 1 because 9 is odd. The second pair is
    //collapsed into 17 (8 + 9), stored at the odd index 3; the third pair is collapsed into 26 (4 + 22),
    //stored at the even index 4; and so on. The figure below summarizes the process for this example array:

    //before: index  0   1   2   3   4   5   6   7   8   9
    //        value {7,  2,  8,  9,  4, 22,  7,  1,  9, 10}
    //               \   /   \   /   \   /   \   /   \   /
    //                \ /     \ /     \ /     \ /     \ /
    //                 V       V       V       V       V
    //after:  index  0   1   2   3   4   5   6   7   8   9
    //        value {0,  9,  0, 17, 26,  0,  8,  0,  0, 19}

    internal class CollapsePairs
    {
        public static void RunCollapsePairs(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                int sum;
                sum = a[i] + a[i + 1];

                if (sum % 2 == 0)
                {
                    a[i] = sum;
                    a[i + 1] = 0;
                }
                else
                {
                    a[i] = 0;
                    a[i + 1] = sum;
                }
                i++;
            }

            DisplayCollapsedPairs(a);
        }

        private static void DisplayCollapsedPairs(int[] a)
        {
            for(int i = 0; i < a.Length; i++)
            {
                Console.Write($"{a[i]}, ");
            }
        }

        //public static void RunCollapsePairs(int[] a)
        //{
        //    for (int i = 0; i < a.Length; i++)
        //    {
        //        var sum = a[i] + a[i + 1];

        //        if ((a[i] + a[i + 1]) % 2 == 0)
        //        {
        //            a[i] = sum;
        //            a[i + 1] = 0;
        //        }
        //        else
        //        {
        //            a[i] = 0;
        //            a[i + 1] = sum;
        //        }

        //        i++;
        //    }

        //    DisplayNewArray(a);
        //}

        //private static void DisplayNewArray(int[] a)
        //{
        //    for(int i = 0; i < a.Length; ++i)
        //    {
        //        Console.Write($"{a[i]}, ");
        //    }
        //}
    }
}
