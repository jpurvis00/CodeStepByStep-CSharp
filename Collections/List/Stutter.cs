/* Write a method stutter that takes a List of strings as a parameter and that 
 * replaces every string with two of that string. For example, if the list 
 * stores the values {"how", "are", "you?"} before the method is called, it should 
 * store the values {"how", "how", "are", "are", "you?", "you?"} after the 
 * method finishes executing.
 */

using Dumpify;

namespace CodeStepByStep_CSharp.Collections.List
{
    public class Stutter
    {
        public static void RunStutter()
        {
            List<string> repeatWords = new() { "how", "are", "you?" };
            int repeat = 2;

            Console.WriteLine("Before Repeat:");
            if (repeat > 0)
            {
                int k = 0;
                int count = repeatWords.Count;

                // can't use repeatWords.Count bc this is consistently changing
                // and we end up in an infinite loop
                for (int i = 0; i < count; i++)
                {
                    // InsertRange inserts an IEnumerable<string> at the specified index.
                    // We need to create a temp list(which is IEnumerable) of strings to insert
                    List<string> newWordRange = new();
                    for (int j = 0; j < repeat - 1; j++)
                    {
                        newWordRange.Add(repeatWords[k]);
                    }
                    repeatWords.InsertRange(k + 1, newWordRange);

                    // jumping ahead by repeat to get the next word
                    k += repeat;
                }
            }
            else
            {
                repeatWords.Clear();
            }

            repeatWords.DumpConsole();
        }
    }
}
