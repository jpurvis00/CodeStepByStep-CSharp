
//Write a method named Sorted that accepts an array of doubles as a parameter
//and returns true if the list is in sorted order and false if not. For example,
//if an array named list stores {1.5, 4.3, 7.0, 19.5, 25.1, 46.2} respectively,
//the call of Sorted(list2) should return true. You may assume the array has at
//least one element. A one-element array is considered to be sorted. Do not
//modify the array passed in.

using System.Net.NetworkInformation;

namespace CodeStepByStep_CSharp.Arrays
{
    public class Sorted
    {
        public static bool RunSorted(double[] list)
        {
            bool sorted = false;

            for(int i = 0; i < list.Length; i++)
            {
                if ( (i + 1) < list.Length && list.Length > 1)
                {
                    if (list[i] < list[i + 1])
                    {
                        sorted = true; 
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return true;
                }
            }

            return sorted;
        }
    }
}
