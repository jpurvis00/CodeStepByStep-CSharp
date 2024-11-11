//Write a method named RemoveAll that accepts as a parameter 
//a List of strings along with an element value string, and modifies 
//the list to remove all occurrences of that string. For example, 
//if the list v contains {"a", "b", "c", "b", "b", "a", "b"}, the 
//call of RemoveAll(v, "b"); should modify it to store {"a", "c", "a"}.

using Dumpify;

namespace CodeStepByStep_CSharp.Collections.List
{
    public class RemoveAll
    {
        public static void RunRemoveAll(List<string> list1, string removeWord)
        {
            list1.DumpConsole();

            for (int i = 0; i < list1.Count; i++)
            {
                list1.RemoveAll(word => word.Equals(removeWord, StringComparison.Ordinal));
            }

            list1.DumpConsole();
        }
    }
}
