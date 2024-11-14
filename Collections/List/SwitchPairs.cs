/* Write a method named SwitchPairs that accepts a generic List of strings as a 
 * parameter and switches the order of pairs of values in the array. Your method 
 * should swap the order of the first two values, then switch the order of the 
 * next two, and so on. For example, if a variable named list stores 
 * {"a", "bb", "c", "ddd", "ee", "f", "g"}, then the call of SwitchPairs(list); 
 * should switch the first pair ("a", "bb"), the second pair ("c", "ddd") 
 * and the third pair ("ee", "f"), to yield this list:

{"bb", "a", "ddd", "c", "f", "ee", "g"}
If there are an odd number of values, the final element is not moved. 
You may assume that the list is not null and that no element of the array is null.
*/

using Dumpify;


namespace CodeStepByStep_CSharp.Collections.List
{
    public class SwitchPairs
    {
        public static void RunSwitchPairs()
        {
            //List<string> words = new() { "a", "bb", "c", "ddd", "ee", "f", "g" };
            List<string> words = new() { "a", "bb", "c", "ddd", "ee", "f" };
            int count = 0;

            if (words.Count % 2 != 0)
            {
                count = words.Count - 1;
            }
            else
            {
                count = words.Count;
            }

            for (int i = 0; i < count; i++)
            {
                string temp = string.Empty;

                temp = words[i];
                words[i] = words[i + 1];
                words[i + 1] = temp;
                i++;
            }

            words.DumpConsole();
        }
    }
}
