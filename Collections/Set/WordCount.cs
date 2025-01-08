/* Write a method named WordCount that accepts a file name as a parameter and opens that file and
 * that returns a count of the number of unique words in the file. Do not worry about capitalization
 * and punctuation; for example, "Hello" and "hello" and "hello!!" are different words for this
 * problem. Use a set as auxiliary storage. 
 */

using System.Globalization;
using System.Text;
using Dumpify;

namespace CodeStepByStep_CSharp.Collections.Set
{
    public class WordCount
    {
        public static void RunWordCount()
        {
            string filePath = @"./Collections/Set/WordCount.txt";

            int wordCount = FindWordCount(filePath);

            Console.WriteLine($"There are {wordCount} unique words in the file.");
        }

        private static int FindWordCount(string filePath)
        {
            HashSet<string> words = new();

            using (StreamReader sr = File.OpenText(filePath))
            {
                string s;

                while ((s = sr.ReadLine()) != null)
                {
                    string newWord = CheckForPunctuation(s);

                    if (!words.Contains(newWord.ToLower(System.Globalization.CultureInfo.InvariantCulture)))
                    {
                        words.Add(newWord.ToLower(CultureInfo.InvariantCulture));
                    }
                }
            }

            words.DumpConsole();

            return words.Count;
        }

        private static string CheckForPunctuation(string word)
        {
            StringBuilder result = new();

            foreach (char c in word)
            {
                if (!char.IsPunctuation(c))
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
    }
}
