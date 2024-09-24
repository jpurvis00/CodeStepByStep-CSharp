

//Write a method named EvenBeforeOdd that accepts an array of integers as a
//parameter and rearranges its elements so that all even values appear
//before all odds. For example, if the following array is passed to your method:

//int[] numbers = { 5, 2, 4, 9, 3, 6, 2, 1, 11, 1, 10, 4, 7, 3 };

//Then after the method has been called, one acceptable ordering of the elements would be:

//                { 4, 2, 4, 10, 2, 6, 3, 1, 11, 1, 9, 5, 7, 3}

//The exact order of the elements does not matter, so long as all even values appear
//before all odd values. For example, the following would also be an acceptable ordering:

//                { 2, 2, 4, 4, 6, 10, 1, 1, 3, 3, 5, 7, 9, 11}

//Do not make any assumptions about the length of the array or the range of values
//it might contain. For example, the array might contain no even elements or no odd elements.

//You should not use any temporary arrays to help you solve this problem. (But you
//may declare as many simple variables as you like, such as ints.) You may not use
//any other data structures such as strings orLists. You should not use the Sort method in your solution.


using System.Runtime.CompilerServices;

namespace CodeStepByStep_CSharp.Arrays
{
    internal class EvenBeforeOdd
    {
        public static void RunEvenBeforeOdd(int[] a1)
        //{

        //    for (int i = 0; i < a1.Length; i++)
        //    {
        //        bool isEven = IsEven(a1[i]);

        //        int odd;
        //        if (!isEven)
        //        {
        //            odd = a1[i];
        //            int k = i;

        //            for (int j = i + 1; j < a1.Length; j++)
        //            {
        //                if (IsEven(a1[j]))
        //                {
        //                    isEven = true;
        //                    break;
        //                }
        //            }

        //            if (isEven)
        //            {
        //                for (int j = i + 1; j < a1.Length; j++)
        //                {
        //                    a1[k] = a1[j];
        //                    k++;
        //                }
        //                a1[a1.Length - 1] = odd;
        //                i--;
        //            }
        //        }
        //    }

        //    PrintArray(a1);
        //    Console.WriteLine();
        //}

        //private static void PrintArray(int[] a1)
        //{
        //    for (int i = 0; i < a1.Length; i++)
        //    {
        //        if (i < a1.Length - 1)
        //        {
        //            Console.Write($"{a1[i]}, ");
        //        }
        //        else
        //        {
        //            Console.Write($"{a1[i]}");
        //        }
        //    }
        //}

        //private static bool IsEven(int a1)
        //{
        //    return a1 % 2 == 0;
        //}

        {
            Console.Write("Original array:                ");
            DisplayArray(a1);

            /* if there are no even numbers in array, display array */
            if (ContainsEvenNumbers(a1) != true)
            {
                Console.Write("\nArray needed no sorting:       ");
                DisplayArray(a1);
                return;
            }

            /* if there are no odd numbers in array, display array */
            if (ContainsOddNumbers(a1) != true)
            {
                Console.Write("\nArray needed no sorting:       ");
                DisplayArray(a1);
                return;
            }

            /* array has both even/odd #s, display array with even #s before odd */
            for (int i = 1; i < a1.Length; i++)
            {
                if (a1[i] % 2 == 0)
                {
                    /* store even number in temp var, this will be moved to the a1[0] spot */
                    int temp = a1[i];

                    /* shift all numbers from the beginning of the array to the right one spot 
                     * ending where the even number was found.  Then replace the a[0] with the
                     * found even # */
                    for (int j = i; j > 0; j--)
                    {
                        a1[j] = a1[j - 1];
                    }

                    a1[0] = temp;
                }
            }

            Console.Write("\nArray with even before odd:    ");
            DisplayArray(a1);
        }

        private static bool ContainsOddNumbers(int[] a1)
        {
            for (int i = 0; i < a1.Length; i++)
            {
                if (a1[i] % 2 != 0)
                {
                    return true;
                }
            }

            return false;
        }

        private static void DisplayArray(int[] a1)
        {
            for (int i = 0; i < a1.Length; i++)
            {
                if (i < a1.Length - 1)
                {
                    Console.Write($"{a1[i]}, ");
                }
                else
                {
                    Console.Write($"{a1[i]}");
                }
            }
        }

        private static bool ContainsEvenNumbers(int[] a1)
        {
            for (int i = 0; i < a1.Length; i++)
            {
                if (a1[i] % 2 == 0)
                {
                    return true;
                }
            }

            return false;
        }

    }
}
