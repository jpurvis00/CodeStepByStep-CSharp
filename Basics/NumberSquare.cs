using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeStepByStep_CSharp.Basics
{
    internal class NumberSquare
    {
        //Write a method named NumberSquare that accepts two integer parameters,
        //a min and a max, and prints the numbers in the range from min to max inclusive
        //in a square pattern.Each line of the square consists of a wrapping sequence of
        //integers increasing from min and max.The first line begins with min, the second
        //line begins with min + 1, and so on.When the sequence in any line reaches max,
        //it wraps around back to min.You may assume that min is less than or equal to max.
        //For example, the call of NumberSquare(1, 5); should print:

        //12345
        //23451
        //34512
        //45123
        //51234

        public static void DisplayNumberSquare(int min, int max)
        {
            for (int i = min; i <= max; i++)
            {
                for (int j = i; j <= max; j++)
                {
                    Console.Write(j);
                }

                for (int j = min; j < i; j++)
                {
                    Console.Write(j);
                }

                Console.WriteLine();
            }
        }
    }
}
