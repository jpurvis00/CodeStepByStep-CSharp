/* Write a method named Stutter that accepts a queue of integers as 
 * a parameter and replaces every element with two copies of itself. 
 * For example, if a queue named q stores {1, 2, 3}, the call of Stutter(q); 
 * should change it to store {1, 1, 2, 2, 3, 3}. 
 *
 * Constraints: Do not use any auxiliary collections as storage.
 */

using Dumpify;

namespace CodeStepByStep_CSharp.Collections.StackAndQueue
{
    public class Stutter
    {
        public static void RunStutter()
        {

            Queue<int> stutterQueue = new(new int[] { 1, 2, 3 });

            ItsStutterTime(stutterQueue);

            stutterQueue.DumpConsole();
        }

        private static void ItsStutterTime(Queue<int> stutterQueue)
        {
            int count = stutterQueue.Count;
            int temp;

            for (int i = 0; i < count; i++)
            {
                temp = stutterQueue.Dequeue();
                stutterQueue.Enqueue(temp);
                stutterQueue.Enqueue(temp);
            }
        }
    }
}
