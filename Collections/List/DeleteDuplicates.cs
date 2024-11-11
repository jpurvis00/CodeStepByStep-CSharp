/* Write a method named DeleteDuplicates that accepts as a parameter a sorted List of strings and that removes any duplicate values from the list. For example, suppose that a List named list contains the values {"be", "be", "is", "not", "or", "question", "that", "the", "to", "to"} After calling DeleteDuplicates(list); the list should store the following values: {"be", "is", "not", "or", "question", "that", "the", "to"} You should assume that the values in the list are sorted, and that therefore all of the duplicates will be grouped together.
 */

using Dumpify;

namespace CodeStepByStep_CSharp.Collections.List
{
    public class DeleteDuplicates
    {
        public static void RunDeleteDuplicates()
        {
            List<string> dupes = new() { "be", "be", "be", "is", "not", "not", "or", "question", "that", "the", "to", "to" };

            for (int i = 0; i < dupes.Count; i++)
            {
                if (i < dupes.Count - 1)
                {
                    while (dupes[i].Equals(dupes[i + 1], StringComparison.Ordinal))
                    {
                        dupes.RemoveAt(i + 1);

                        if ((i + 1) >= dupes.Count)
                        {
                            break;
                        }
                    }
                }
            }

            dupes.DumpConsole();
        }
    }
}
