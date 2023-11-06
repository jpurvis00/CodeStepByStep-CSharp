using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CodeStepByStep_CSharp.Arrays
{
    //Write a method named ComputeAverage that computes and returns the mean
    //of all elements in an array of integers.For example, if an array named
    //a contains[1, -2, 4, -4, 9, -6, 16, -8, 25, -10], then the call of ComputeAverage(a) should return 2.5.

    //Constraints: You may assume that the array contains at least one element.
    //Your method should not modify the elements of the array.

    internal class ComputeAverage
    {
        public static void RunComputeAverage(int[] a) 
        { 
            double sum = 0;
            
            foreach (var item in a)
            {
                sum += item;
            }

            var mean = sum / a.Length;

            Console.WriteLine($"mean: {mean}");
        }
    }
}
