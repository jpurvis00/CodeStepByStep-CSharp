/* Write a method named SplitStack that accepts as a parameter a 
 * Stack of integers, and re-orders it so that all the non-negative 
 * numbers are at the top in the reverse of their original relative order, 
 * and all the negative numbers are at the bottom in the reverse of 
 * their original relative order. For example, if passed the stack 
 *
 * { 7, 2, -3, -6, 5, -1, 0, 4 }
 *
 * your method should modify the stack to store 
 *
 * {-3, -6, -1, 7, 2, 5, 0, 4}. 
 *
 * Constraints: Do not declare any auxiliary data structures 
 * (e.g. arrays, Grids, Lists, etc.) other than a single Queue of integers. 
 */
using Dumpify;

namespace CodeStepByStep_CSharp.Collections.StackAndQueue
{
    public class SplitStacks
    {
        public static void RunSplitStack()
        {
            Stack<int> redoStack = new(new int[] { 7, 2, -3, -6, 5, -1, 0, 4 });
            //Stack<int> redoStack = new(new int[] { 4, 0, -1, 5, -6, -3, 2, 7 });
            Queue<int> tempQueue = new();

            Console.WriteLine("Originial state");
            redoStack.DumpConsole();
            tempQueue.DumpConsole();

            EmptyStack(redoStack, tempQueue);

            Console.WriteLine("After moving stack into queue");
            redoStack.DumpConsole();
            tempQueue.DumpConsole();

            SplitNegativeFromPositive(redoStack, tempQueue);

            Console.WriteLine("Split negative from positive numbers");
            redoStack.DumpConsole();
            tempQueue.DumpConsole();

            PopulateStack(redoStack, tempQueue);

            Console.WriteLine("Move from queue back to stack");
            redoStack.DumpConsole();
            tempQueue.DumpConsole();

            EmptyStack(redoStack, tempQueue);
            SplitNegativeFromPositive(redoStack, tempQueue);
            PopulateStack(redoStack, tempQueue);

            //I'm not entirely sure if the example in the directions is correct or not.
            //To get it the answer above, we run it through a second time to reverse the 
            //#'s into the correct order.
            Console.WriteLine("Final");
            redoStack.DumpConsole();
            tempQueue.DumpConsole();
        }

        private static void PopulateStack(Stack<int> redoStack, Queue<int> tempQueue)
        {
            int tempQueueCount = tempQueue.Count;

            for (int i = 0; i < tempQueueCount; i++)
            {
                redoStack.Push(tempQueue.Dequeue());
            }
        }

        private static void SplitNegativeFromPositive(Stack<int> redoStack, Queue<int> tempQueue)
        {
            //Puts negatives in the stack and positives in the queue.
            int tempQueueCount = tempQueue.Count;
            int numb;

            for (int i = 0; i < tempQueueCount; i++)
            {
                if (tempQueue.TryPeek(out numb))
                {
                    if (numb >= 0)
                    {
                        tempQueue.Enqueue(tempQueue.Dequeue());
                    }
                    else
                    {
                        redoStack.Push(tempQueue.Dequeue());
                    }
                }
            }
        }

        private static void EmptyStack(Stack<int> redoStack, Queue<int> tempQueue)
        {
            while (redoStack.Count != 0)
            {
                tempQueue.Enqueue(redoStack.Pop());
            }
        }
    }
}
