/* Write a method named Reorder that accepts as a parameter a 
 * queue of integers that are already sorted by absolute value, 
 * and modifies it so that the integers are sorted normally. 
 * For example, if a queue variable named q stores the following elements:
 *
 * front {1, -2, 4, 5, -7, -9, -12, 28, -34} back
 *
 * Then the call of Reorder(q); should modify it to store the following values:
 *
 * front {-34, -12, -9, -7, -2, 1, 4, 5, 28} back
 * Constraints: You may use a single stack as auxiliary storage.
*/
using Dumpify;

namespace CodeStepByStep_CSharp.Collections.StackAndQueue
{
    public class Reorder
    {
        public static void RunReorder()
        {
            Queue<int> sortedQueue = new(new[] { 1, -2, 4, 5, -7, -9, -12, 28, -34 });

            ReorderQueue(sortedQueue);
        }

        private static void ReorderQueue(Queue<int> sortedQueue)
        {
            Stack<int> stackForSort = new();

            //we are going to continue to dequeue items from the queue and 
            //push them on the stack and repush items from the stack back 
            //into the queue until the items are sorted in the stack. At this
            //point, the queue should be empty once all items are sorted. We
            //will then push everything from the stack back into the queue
            //giving us a sorted queue.
            while (sortedQueue.Count != 0)
            {
                int temp = sortedQueue.Dequeue();

                if (!stackForSort.TryPeek(out int tempStack))
                {
                    stackForSort.Push(temp);
                    continue;
                }

                int stackCount = stackForSort.Count;

                for (int j = 0; j <= stackCount; j++)
                {
                    if (stackForSort.TryPeek(out int result))
                    {
                        if (temp > result)
                        {
                            sortedQueue.Enqueue(stackForSort.Pop());
                        }
                        else
                        {
                            stackForSort.Push(temp);
                            break;
                        }
                    }
                    else
                    {
                        stackForSort.Push(temp);
                    }
                }
            }

            //still need to pop stack and put all values back in queue
            sortedQueue.DumpConsole();
            stackForSort.DumpConsole();
        }
    }
}
