using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeStepByStep_CSharp.Arrays
{
    //Write a method named Contains that accepts two arrays of integers a1 and a2 as
    //parameters and that returns a bool value indicating whether or not a2's sequence of
    //elements appears in a1 (true for yes, false for no). The sequence of elements in a2
    //may appear anywhere in a1 but must appear consecutively and in the same order. For
    //example, if variables called a1 and a2 store the following values:

    //int[] a1 = { 1, 6, 2, 1, 4, 1, 2, 1, 8 };
    //int[] a2 = { 1, 2, 1 };

    //Then the call of Contains(a1, a2) should return true because a2's sequence of values
    //{1, 2, 1} is contained in a1 starting at index 5. If a2 had stored the values {2, 1, 2},
    //the call of Contains(a1, a2) would return false because a1 does not contain that sequence
    //of values. Any two arrays with identical elements are considered to contain each other,
    //so a call such as Contains(a1, a1) should return true.

    //You may assume that both arrays passed to your method will have lengths of at least 1.
    //You may not use any strings to help you solve this problem, nor methods that produce string
    //results such as converting each array into a string.

    internal class Contains
    {
        public static bool RunContains(int[] a1, int[] a2)
        {
            for (int i = 0; i < a1.Length; i++)
            {
                bool consecutive = false;
                for (int j = 0; j < a2.Length; j++)
                {
                    if (a2[j] == a1[i] && i + 1 < a1.Length)
                    {
                        consecutive = true;
                        i++;
                    }
                    else
                    {
                        consecutive = false;
                        break;
                    }
                }

                if (consecutive)
                {
                    return true;
                }
            }

            return false;
        }

        //public static bool RunContains(int[] a1, int[] a2)
        //{
        //    bool consecutiveSequence = false;

        //    for (int i = 0; i < a1.Length; i++)
        //    {
        //        for (int j = 0; j < a2.Length; j++)
        //        {
        //            if (a1[i + j] == a2[j])
        //            {
        //                consecutiveSequence = true;                        
        //            }
        //            else
        //            {
        //                consecutiveSequence = false;
        //                break;
        //            }
        //        }

        //        if (consecutiveSequence == true)
        //        {
        //            return true;
        //        }
        //    }

        //    return false;
        //}
    }
}
