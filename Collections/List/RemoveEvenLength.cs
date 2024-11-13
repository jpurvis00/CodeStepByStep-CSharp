//Write a method named RemoveEvenLength that accepts a List of strings as a 
//parameter and that removes all of the strings of even length from the list. 
//For example, if a List variable named list contains the values 
//["hi", "there", "how", "is", "it", "going", "good", "sirs"], the call of 
//RemoveEvenLength(list); would change it to store ["there", "how", "going"].

using Dumpify;

namespace CodeStepByStep_CSharp.Collections.List
{
    public class RemoveEvenLength
    {
        public static void RunRemoveEvenLength()
        {
            List<string> evenLengthWords = new() { "hi", "there", "how", "is", "it", "going", "good", "sirs" };

            for (int i = 0; i < evenLengthWords.Count; i++)
            {
                if (evenLengthWords[i].Length % 2 == 0)
                {
                    evenLengthWords.RemoveAt(i);
                    i--;
                }
            }

            evenLengthWords.DumpConsole();
        }
    }
}
