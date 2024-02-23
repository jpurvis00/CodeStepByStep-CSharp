
//Write a variable declaration and for loop necessary to create and
//initialize an integer array named squares that contains the following values:
//{ 0, 1, 4, 9, 16, 25, 36, 49, 64, 81, 100}

namespace CodeStepByStep_CSharp.Arrays
{
    public class Squared
    {
        public static void RunSquared()
        {
            int[] squaredArray = new int[11];

            for (int i = 0; i < squaredArray.Length; i++)
            {
                squaredArray[i] = i * i;    
            }

            Console.Write("Squared array: ");
            
            for (int i = 0; i < squaredArray.Length; i++)
            {
                Console.Write($"{squaredArray[i]} ");    
            }

        }
    }
}
