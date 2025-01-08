/* Write a method MaxLength that accepts as a parameter a HashSet of strings, 
 * and that returns the length of the longest string in the set. If your 
 * method is passed an empty set, it should return 0.
 */

namespace CodeStepByStep_CSharp.Collections.Set
{
    public class MaxLength
    {
        public static void RunMaxLength()
        {
            HashSet<string> words = new() { "hello", "jeff", "how are you doing", "stephanie", "I love my wife" };

            Console.WriteLine($"Longest word has {FindLargestString(words)} characters");
        }

        private static int FindLargestString(HashSet<string> words)
        {
            int maxLength = 0;

            foreach (string word in words)
            {
                int length = word.Length;

                if (length > maxLength)
                {
                    maxLength = length;
                }
            }

            return maxLength;
        }
    }
}
