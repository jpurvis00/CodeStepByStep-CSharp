/* Write a method named IsSorted accepts a stack of integers as a 
 * parameter and returns true if the elements in the stack occur in 
 * ascending (non-decreasing) order from top to bottom, else false. 
 * That is, the smallest element should be on top, growing larger 
 * toward the bottom. An empty or one-element stack is considered 
 * to be sorted. For example, if passed the following stack, your method should return true:
 *
 * bottom {20, 20, 17, 11, 8, 8, 3, 2} top
 *
 * The following stack is not sorted (the 15 is out of place), 
 * so passing it to your method should return a result of false:
 *
 * bottom {18, 12, 15, 6, 1} top 
 *
 * When your method returns, the stack should be in the same state as 
 * when it was passed in. In other words, if your method modifies the 
 * stack, you must restore it before returning.
 *
 * Constraints: You may use one queue or one stack (but not both) as 
 * auxiliary storage. Do not declare any other auxiliary data structures 
 * (e.g. arrays, Grids, Lists, etc.), but you can have as many simple 
 * variables as you like. Your solution should run in O(N) time, where 
 * N is the number of elements of the stack.
 */
using Dumpify;

namespace CodeStepByStep_CSharp.Collections.StackAndQueue
{
    public class IsSorted
    {
        public static void RunIsSorted()
        {
            Stack<int> numbInAscOrder = new(new int[] { 20, 20, 17, 11, 8, 8, 3, 2 });
            //Stack<int> numbInAscOrder = new(new int[] { 18, 12, 15, 6, 1 });
            //Stack<int> numbInAscOrder = new(new int[] { 18 });

            numbInAscOrder.DumpConsole();

            Console.WriteLine($"The stack is sorted: {CheckIfStackIsAsc(numbInAscOrder)}");

            numbInAscOrder.DumpConsole();
        }

        private static bool CheckIfStackIsAsc(Stack<int> numbInAscOrder)
        {
            Stack<int> dumpInts = new();
            bool isSorted = true;

            if (numbInAscOrder.Count <= 1)
            {
                isSorted = true;
            }

            while (numbInAscOrder.Count != 1)
            {
                int top = numbInAscOrder.Pop();
                dumpInts.Push(top);

                if (top > numbInAscOrder.Peek())
                {
                    isSorted = false;
                }
            }

            ResetOriginalStack(numbInAscOrder, dumpInts);
            return isSorted;
        }

        private static void ResetOriginalStack(Stack<int> numbInAscOrder, Stack<int> dumpInts)
        {
            while (dumpInts.Count != 0)
            {
                int top = dumpInts.Pop();
                numbInAscOrder.Push(top);
            }
        }
    }
}
