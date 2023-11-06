using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeStepByStep_CSharp.Arrays
{
    //Write a method named Collapse that accepts an array of integers as a parameter and
    //returns a new array where each pair of integers from the original array has been
    //replaced by the sum of that pair.For example, if an array called a stores {7, 2, 8, 9, 4, 13, 7, 1, 9, 10},
    //then the call of Collapse(a) should return a new array containing {9, 17, 17, 8, 19}.
    //The first pair from the original list is Collapsed into 9 (7 + 2), the second pair
    //is Collapsed into 17 (8 + 9), and so on.

    //If the list stores an odd number of elements, the last element is not collapsed.
    //For example, if the array had been {1, 2, 3, 4, 5}, then the call would return {3, 7, 5}.
    //Your method should not change the array that is passed as a parameter.

    internal class Collapse
    {
        public static void RunCollapse(int[] a)
        {
            int newArraySize;

            newArraySize = a.Length % 2 == 0 ? a.Length / 2 : (a.Length / 2) + 1;

            int[] collapsedArray = new int[newArraySize];
            int collapsedArrayIndex = 0;
           
            for(int i = 0; i < a.Length; i++)
            {
                if(i + 1 < a.Length)
                {
                    collapsedArray[collapsedArrayIndex] = a[i] + a[i + 1];
                }
                else
                {
                    collapsedArray[collapsedArrayIndex] = a[i];
                }
                collapsedArrayIndex++;
                i++;
            }

            DisplayArray(collapsedArray);
        }

        private static void DisplayArray(int[] collapsedArray)
        {
            for(int i = 0; i < collapsedArray.Length; i++)
            {
                Console.Write($"{collapsedArray[i]}, ");
            }

            Console.WriteLine();
        }
    }
}
