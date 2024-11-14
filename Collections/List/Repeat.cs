//Write a method named Repeat that accepts a List of strings and an 
//integer k as parameters and that replaces each element with k 
//copies of that element. For example, if the list stores the values 
//["how", "are", "you?"] before the method is called and k is 4, 
//it should store the values 
//["how", "how", "how", "how", "are", "are", "are", "are", "you?", "you?", "you?", "you?"] 
//after the method finishes executing. If k is 0 or negative, the list should be empty after the call.

using Dumpify;

namespace CodeStepByStep_CSharp.Collections.List
{
    public class Repeat
    {
        public static void RunRepeat()
        {
            List<string> repeatWords = new() { "how", "are", "you?" };
            int repeat = 4;

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
