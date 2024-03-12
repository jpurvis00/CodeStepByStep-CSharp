
//Write a method named PairFrequencies that prints particular data about
//two-letter pairs in a collection of words. In the English language,
//some combinations of adjacent letters are more common than others.
//For example, 'h' often follows 't' ("th"), but rarely would you see 'x'
//following 't' ("tx"). Knowing how often a given letter follows other
//letters in the English language is useful in many contexts. In cryptography,
//we use this data to crack substitution ciphers (codes where each letter has
//been replaced by a different letter, for example: A - M, B - T, etc.) by
//identifying which possible decoding substitutions produce plausible letter
//combinations and which produce nonsense.

//For this problem, you will write a method named PairFrequencies that accepts a
//SortedSet representing a dictionary of words. Your method will examine the
//dictionary and print all 2-character sequences of letters along with a count of
//how many times each pairing occurs. For example, suppose a set variable named
//dict contains the following words:

//{ "banana", "bends", "i", "mend", "sandy"}
//This dictionary contains the following two-character pairs: "ba", "an", "na", "an", "na"
//from banana; "be", "en", "nd", "ds" from bends; "me", "en", "nd" from mend;
//and "sa", "an", "nd", "dy" from sandy. (Note that "i" is only one character long,
//so it contains no pairs.) So the call of PairFrequencies(dict); would print the following output:

//an: 3
//ba: 1
//be: 1
//ds: 1
//dy: 1
//en: 2
//me: 1
//na: 2
//nd: 3
//sa: 1

//Notice that pairings that occur more than once in the same word should be
//counted as separate occurrences. For example, "an" and "na" each occur twice in "banana".

//Constraints: Obey the following restrictions in your solution.
//You may create one additional data structure (stack, queue, set, dictionary, etc.)
//as auxiliary storage. A nested structure, such as a set of lists, counts as one
//additional data structure. (You can have as many simple variables as you like.)
//You should not modify the contents of the set passed to your method.
//Declare your method in such a way that any caller can be sure that this will not happen.
//You should loop over the contents of the set no more than once.
//Your solution should run in no worse than O(N2) time, where N is the number of pairs in the dictionary.


namespace CodeStepByStep_CSharp.Collections.Dictionary
{
    public class PairFrequencies
    {
        public static void RunPairFrequencies(List<string> list)
        {
            Dictionary<string, int> pairs = new Dictionary<string, int>();

            foreach(var word in list)
            {
                for(int i = 0; i < word.Length; i++)
                {
                    if (i < word.Length - 1)
                    {
                        string temp = word.Substring(i, 2);

                        if (pairs.ContainsKey(temp) == false)
                        {
                            pairs.Add(temp, 1);
                        }
                        else
                        {
                            pairs[temp]++;
                        }
                    }
                }
            }

            DisplayOutput(pairs);
        }

        private static void DisplayOutput(Dictionary<string, int> pairs)
        {
            foreach (var kvp in pairs)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
