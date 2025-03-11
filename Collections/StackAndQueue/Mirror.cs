/* Write a method named Mirror that accepts a queue of strings as a 
 * parameter and appends the queue's contents to itself in reverse order. 
 * For example, if a queue named q stores {"a", "b", "c"}, the call of 
 * Mirror(q); should change it to store {"a", "b", "c", "c", "b", "a"}.
 *
 * Constraints: You may declare a single stack or queue as auxiliary storage.
 */
using Dumpify;

namespace CodeStepByStep_CSharp.Collections.StackAndQueue
{
    public class Mirror
    {
        public static void RunMirror()
        {
            Queue<string> queueOfStrings = new(new string[] { "a", "b", "c" });
            Stack<string> stackOfStrings = new();

            CreateMirror(queueOfStrings, stackOfStrings);
        }

        private static void CreateMirror(Queue<string> queueOfStrings, Stack<string> stackOfStrings)
        {
            queueOfStrings.DumpConsole();

            for (int i = 0; i < queueOfStrings.Count; i++)
            {
                string temp = queueOfStrings.Dequeue();
                queueOfStrings.Enqueue(temp);
                stackOfStrings.Push(temp);
            }

            int count = stackOfStrings.Count;

            for (int i = 0; i < count; i++)
            {
                queueOfStrings.Enqueue(stackOfStrings.Pop());
            }

            queueOfStrings.DumpConsole();
            stackOfStrings.DumpConsole();

        }
    }
}
