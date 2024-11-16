/* Write a method named Twice that accepts a List of strings as a 
 * parameter and that appends a second occurrence of the entire 
 * list to itself. For example, if a List named list stores the values 
 * {"how", "are", "you?"}, the call of Twice(list); should modify the 
 * list to store {"how", "are", "you?", "how", "are", "you?"}. 
 */

using Dumpify;

namespace CodeStepByStep_CSharp.Collections.List
{
    public class Twice
    {
        public static void RunTwice()
        {
            List<string> words = new() { "how", "are", "you?" };
            /* must set count here instead of using words.Count in the 
             * for loop. Will create a endless loop.
             */
            int count = words.Count();

            for (int i = 0; i < count; i++)
            {
                words.Add(words[i]);
            }

            words.DumpConsole();
        }
    }
}
