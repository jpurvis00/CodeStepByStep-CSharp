
namespace CodeStepByStep_CSharp.Arrays
{
    internal class Banish
    {
        //Write a method named Banish that accepts two arrays of integers a1 and a2 as
        //parameters and removes all occurrences of a2's values from a1. An element is
        //"removed" by shifting all subsequent elements one index to the left to cover
        //it up, placing a 0 into the last index. The original relative ordering of a1's
        //elements should be retained.

        //For example, suppose the following two arrays are declared and the following call is made:
        //int[] a1 = { 42, 3, 9, 42, 42, 0, 42, 9, 42, 42, 17, 8, 2222, 4, 9, 0, 1 };
        //int[] a2 = { 42, 2222, 9 };
        //Banish(a1, a2);

        //After the call has finished, the contents of a1 should become:
        //{3, 0, 17, 8, 4, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}

        //Notice that all occurrences of the values 42, 2222, and 9 have been removed
        //and replaced by 0s at the end of the array, and the remaining values have
        //shifted left to compensate.

        //Do not make any assumptions about the length of the arrays or the ranges of
        //values each might contain.For example, each array might contain no elements
        //or just one element, or very many elements. (If a2 is an empty array that
        //contains no elements, a1 should not be modified by the call to your method.)
        //You may assume that the arrays passed are not null. You may assume that the
        //values stored in a2 are unique and that a2 does not contain the value 0.

        //You may not use any temporary arrays to help you solve this problem.
        //(But you may declare as many simple variables as you like, such as ints.)
        //You also may not use any other data structures or complex types such as
        //strings, or other data structures such as the List class.

        public static void RunBanish()
        {
            Console.WriteLine("start");
            int[] a1 = { 42, 3, 9, 42, 42, 0, 42, 9, 42, 42, 17, 8, 2222, 4, 9, 0, 1 };
            int[] a2 = { 42, 2222, 9 };

            for (int i = 0; i < a2.Length; i++)
            {
                for (int j = 0; j < a1.Length; j++)
                {
                    if (a1[j] == a2[i])
                    {
                        bool redoLoop = false;
                        for (int k = j; k < a1.Length; k++)
                        {
                            if (k + 1 < a1.Length)
                            {
                                a1[k] = a1[k + 1];

                                if (a1[k] == a2[i])
                                {
                                    redoLoop = true;
                                }
                            }
                            else
                            {
                                a1[k] = 0;
                                if (redoLoop)
                                {
                                    j--;
                                    redoLoop = false;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

//        public static void BanishArrayNumbersRefactored(int[] a1, int[] a2)
//        {
//            /* I think the following solution is a little less confusing.
//             * We create an array of boolean types(which defualt to false), 
//             * and mark change the value to true if it matches one of the 
//             * values in a2.
//             */
//            bool[] toRemove = new bool[a1.Length];
//
//            for(int i = 0; i < a1.Length; i++)
//            {
//                for (int j = 0; j < a2.Length; j++)
//                {
//                    if (a1[i] == a2[j])
//                    {
//                        toRemove[i] = true;
//                    }
//                }
//            }
//
//            int newA1Index = 0;
//
//            /* Next we go through the boolean array and if it's true, do nothing.
//             * If it's false, we the value in a1 starting at place 0.  Then increase
//             * by 1 to put the next false value in and so on.
//             */
//            for (int i = 0; i < a1.Length; i++)
//            {
//                if (toRemove[i] == false)
//                {
//                    a1[newA1Index] = a1[i];
//                    newA1Index++;
//                }
//            }
//
//            /* We then add 0's to the end of the array to keep it the same size
//             * as the original a1 array.
//             */
//            for(int i = newA1Index; i < a1.Length; i++)
//            {
//                a1[i] = 0;
//            }
//            
//            DisplayModifiedArra(a1);
//        }
//
//        public static void BanishArrayNumbers(int[] a1, int[] a2)
//        {
//            bool decreaseJByOne = false;
//
//            /* First loop "loads" 1 val from the a2 array to compare against the entire
//             * a1 array 1 time through.
//             */
//            for(int i = 0; i < a2.Length; i++)
//            {
//                /* Second loop iterates over every value in the a1 array */
//                for(int j = 0; j < a1.Length; j++)
//                {
//                    decreaseJByOne = false;
//
//                    /* A value in the a1 array matches a value in the a2 array */
//                    if (a1[j] == a2[i])
//                    {
//                        a1[j] = a1[j + 1];
//
//                        /* Needed in case there are two values next to each other that are the 
//                         * same and need to be removed.  If we don't decrease by one, the 2nd 
//                         * value is moved to the left by one and then missed on the next loop through.
//                         */
//                        decreaseJByOne = true;
//
//                        /* Move all values in the array to the left by 1 */
//                        for (int k = j + 1; k < a1.Length - 1; k++)
//                        {
//                            a1[k] = a1[k+1];
//                        }
//                       
//                        /* Adds 0 to the end of the array */
//                        if (a1[a1.Length - 1] == a2[i])
//                        {
//                            a1[a1.Length - 1] = 0;
//                        }
//                        else
//                        {
//                            a1[a1.Length - 1] = 0;
//                        }
//                    }
//
//                    if (decreaseJByOne) { j--; }
//                }
//            }
//
//            DisplayModifiedArra(a1);
//        }
//
//        private static void DisplayModifiedArra(int[] a1)
//        {
//            for (int i = 0; i < a1.Length; i++)
//            {
//                Console.Write($"{a1[i]}, ");
//            }
//        }
//    }
//}
