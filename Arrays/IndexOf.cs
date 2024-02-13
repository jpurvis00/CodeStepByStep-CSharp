using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method named IndexOf that returns the index of a particular value in an array of integers.
//The method should return the index of the first occurrence of the target value in the array.
//If the value is not in the array, it should return -1. For example, if an array called list stores the following values:

//int[] list = { 42, 7, -9, 14, 8, 39, 42, 8, 19, 0 };
//Then the call IndexOf(list, 8) should return 4 because the index of the first occurrence of
//value 8 in the array is at index 4. The call IndexOf(list, 2) should return -1 because value 2 is not in the array.

namespace CodeStepByStep_CSharp.Arrays
{
    public static class IndexOf
    {
        public static void RunIndexOf()
        {
            int[] list = { 42, 7, -9, 14, 8, 39, 42, 8, 19, 0 };
            Console.WriteLine(IndexOfMethod(list, 8));
            Console.WriteLine(IndexOfMethod(list, 2));
            Console.WriteLine(IndexOfMethod(list, 42));
        }

        private static int IndexOfMethod(int[] list, int numbToCheck)
        {
            for(int i= 0; i < list.Length; i++)
            {
                if (list[i] == numbToCheck)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}




















//for (int i = 0; i < list.Length; i++)
//{
//    if (list[i] == target)
//    {
//        return i;
//    }
//}
//return -1;
