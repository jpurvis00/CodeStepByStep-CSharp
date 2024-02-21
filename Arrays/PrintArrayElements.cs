
//Write a method named Print that accepts an array of integers as a parameter
//and Prints them, one per line, in the format shown. Your code should work
//for an array of any size. For example, if an array named a contains the
//elements [32, 5, 27, -3, 2598], then the call of Print(a); should produce the following output:

//element[0] is 32
//element[1] is 5
//element[2] is 27
//element[3] is -3
//element[4] is 2598

namespace CodeStepByStep_CSharp.Arrays
{
    public class PrintArrayElements
    {
        public static void Print(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"element[{i}] is {array[i]}");
            }
        }
    }
}
