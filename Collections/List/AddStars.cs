
/* Write a method named AddStars that accepts as a parameter a List of strings, and modifies the list by placing a "*" element between elements, as well as at the start and end of the list. For example, if the list v contains {"the", "quick", "brown", "fox"}, the call of addStars(v); should modify it to store {"*", "the", "*", "quick", "*", "brown", "*", "fox", "*"}.
 */
using Dumpify;

namespace CodeStepByStep_CSharp.Collections.List
{
    public class AddStars
    {
        public static void RunAddStars()
        {
            List<string> wordList = new() { "the", "quick", "brown", "fox" };

            int total = wordList.Count;

            for (int i = 0; i < (total + total + 1); i++)
            {
                if (i % 2 == 0)
                {
                    wordList.Insert(i, "*");
                }
            }

            wordList.DumpConsole();
        }
    }
}
