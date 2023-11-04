using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CodeStepByStep_CSharp.Arrays
{
    internal class ArrayMystery
    {
        //Consider the following method:

        //public static void Mystery(int[] list)
        //{
        //    for (int i = 1; i < list.Length; i++)
        //    {
        //        list[i] = list[i] + list[i - 1];
        //    }
        //}

        //Indicate in the right-hand column what values would be stored in the
        //array after the method mystery executes if the integer array in the
        //left-hand column is passed as a parameter to Mystery.
        //Be sure to enter your array in correct format, and entering elements
        //with their appropriate type.For example, for an int[] holding the
        //elements 1, 2, and 5, this would be entered as:

        //{ 1, 2, 5}

        //{8} = 8	
        //{6, 3} = 6, 9 
        //{ 2, 4, 6} = 2, 6, 12
        //{ 1, 2, 3, 4} = 1, 3, 6, 10
        //{ 7, 3, 2, 0, 5} = 7, 10, 12, 12, 17

        public static void Mystery(int[] list)
        {
            for (int i = 1; i < list.Length; i++)
            {
                list[i] = list[i] + list[i - 1];
            }
        }

    }
}
