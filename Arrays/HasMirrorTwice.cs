using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method named HasMirrorTwice that accepts two arrays of integers a1 and a2 as
//parameters and returns true if a1 contains all the elements of a2 in reverse
//order at least twice (and false otherwise). For example, if a2 stores the
//elements {1, 2, 3} and a1 stores the elements {6, 3, 2, 1, 4, 1, 3, 2, 1, 5},
//your method would return true.

//Assume that both arrays passed to your method will have a length of at least 1.
//This means that the shortest possible mirror will be of length 1, representing a
//single element (which is its own mirror). A sequence that is a palindrome (the same
//forwards as backwards) is considered its own mirror and should be included in your computations.
//For example, if a1 is {6, 1, 2, 1, 4, 1, 2, 1, 5} and a2 is {1, 2, 1}, your method
//should return true. The two occurrences of the mirror might overlap, as shown in the fourth sample call below.

//The following table shows some calls to your method and their expected results:

//Arrays Returned Value
//int[] a1 = { 6, 1, 2, 1, 3, 1, 3, 2, 1, 5};
//int[] a2 = { 1, 2 };
//HasMirrorTwice(a1, a2) returns true
//int[] a3 = { 5, 8, 4, 18, 5, 42, 4, 8, 5, 5};
//int[] a4 = { 4, 8, 5 };
//HasMirrorTwice(a3, a4) returns false
//int[] a5 = { 6, 3, 42, 18, 12, 5, 3, 42, 3, 42};
//int[] a6 = { 42, 3 };
//HasMirrorTwice(a5, a6) returns true
//int[] a7 = { 6, 1, 2, 4, 2, 1, 2, 4, 2, 1, 5};
//int[] a8 = { 1, 2, 4, 2, 1 };
//HasMirrorTwice(a7, a8) returns true
//int[] a9 = { 0, 0};
//int[] aa = { 0 };
//HasMirrorTwice(a9, aa) returns true
//int[] ab = { 8, 9, 2, 1};
//int[] ac = { 5, 7, 1, 2, 9, 8 };
//HasMirrorTwice(ab, ac) returns false

//Do not modify the contents of the arrays passed to your method as parameters.

namespace CodeStepByStep_CSharp.Arrays
{
    public class HasMirrorTwice
    {

        public static bool RunHasMirrorTwice(int[] a, int[] b)
        {
            int count = 0;
            int totalCount = 0;

            for(int i = 0; i < a.Length; i++)
            {
                int k = i;
                
                for(int j = b.Length - 1; j >= 0; j--)
                {
                    if(k < a.Length)
                    {
                        if (a[k] == b[j])
                        {
                            k++;
                            count++;
                        }
                        else
                        {
                            count = 0;
                            break;
                        }

                        if (count >= b.Length)
                        {
                            totalCount++;
                            break;
                        }
                    }
                }
            }

            if(totalCount >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
