//Write a method RemoveDuplicates that takes as a parameter a sorted List of 
//strings and that eliminates any duplicates from the list. For example, suppose 
//that a variable called list contains the following values: 
//{"be", "be", "is", "not", "or", "question", "that", "the", "to", "to"} 
//After calling RemoveDuplicates(list); the list should store the following values: 
//{"be", "is", "not", "or", "question", "that", "the", "to"}

using Dumpify;

namespace CodeStepByStep_CSharp.Collections.List
{
    public class RemoveDuplicates
    {
        //3 different solutions below. Which one just depends on the instructions above. Looks like
        //it's probably asking to just use the original list and manipulate it. 
        //Using a hashset would be better and faster.
        public static void RunRemoveDuplicates()
        {
            List<string> words = new() { "be", "be", "is", "not", "or", "question", "that", "the", "to", "to" };

            //This will remove the dupes by createing a hashset and then adding items into a new
            //list.
            List<string> uniqueWords = RemoveDuplicatesWords(words);

            //This will just add words to a hashset which by default will create a list of unique
            //words since it's the default behavior of a hashset.
            HashSet<string> uniqueWords2 = new();

            foreach (string word in words)
            {
                uniqueWords2.Add(word);
            }

            //This will remove the dupes from the list and keep the original list intact
            //for (int i = 0; i < words.Count; i++)
            //{
            //    if (i == words.Count)
            //    {
            //        break;
            //    }

            //    if (words[i].Equals(words[i + 1]))
            //    {
            //        words.RemoveAt(i + 1);
            //    }
            //}

            //uniqueWords.DumpConsole();
            uniqueWords2.DumpConsole();
        }


        public static List<string> RemoveDuplicatesWords(List<string> words)
        {
            HashSet<string> seen = new(StringComparer.Ordinal);
            List<string> results = new();

            foreach (string word in words)
            {
                if (seen.Add(word))
                {
                    results.Add(word);
                }
            }

            //seen.DumpConsole();
            return results;
        }
    }
}
