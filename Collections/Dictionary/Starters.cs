
//Write a method named Starters that accepts two parameters: a list of strings, and an integer k.
//Your method should examine the strings in the list passed and return a set of all first
//characters that occur at least k times. In other words, if k or more strings in the list start
//with a particular character at index 0 of the string (case-insensitively), that character should
//be part of the set that you return. All elements of your set should be in lowercase. For example,
//consider a list variable called v containing the following elements:

//{ "hi", "how", "are", "He", "", "Marty!", "this", "morning?", "fine.", "?foo!", "", "HOW", "A"}
//Two words in the list start with "a", one starts with "f", four start with "h", two start with "m",
//one starts with "t", and one starts with "?". Therefore the call of Starters(v, 2) should return a set containing:

//{ 'a', 'h', 'm'}
//The call of Starters(v, 3) on the same list should return a set containing:

//{ 'h'}
//If no start character occurs k or more times, return an empty set. The characters should
//appear in your set in alphabetical order. Note that some of the elements of the list might
//be empty strings; empty strings have no first character, so your code should not consider
//them when counting. (But your code shouldn't crash on an empty string.)

//Constraints: Obey the following restrictions in your solution.

//You will need to construct your set to be returned, and in addition to that,
//you may create one additional data structure (stack, queue, set, dictionary, etc.)
//as auxiliary storage. (You can have as many simple variables as you like.)
//You should not modify the contents of the list passed to your method.
//Declare your method in such a way that any caller can be sure that this will not happen.
//Your solution should run in no worse than O(N log N) time, where N is the number of pairs in the dictionary.


using System.Runtime.CompilerServices;

namespace CodeStepByStep_CSharp.Collections.Dictionary
{
    public class Starters
    {
        private static List<string>? _listOfString;

        public static void RunStarters(List<string> list, int numbOfOccurrences)
        {
            _listOfString = list;
            
            Dictionary<char, int> starters = CreateDictionary(list);
            List<char> letters = CreateList(starters, numbOfOccurrences);
            DisplayDictionary(starters);
            DisplayListOfOccurrences(letters);
        }

        private static void DisplayListOfOccurrences(List<char> letters)
        {
            foreach (char c in letters)
            {
                Console.Write($"'{c}' ");
            }
        }

        private static List<char> CreateList(Dictionary<char, int> starters, int numbOfOccurrences)
        {
            List<char> list = new List<char>();
            
            foreach (var key in starters)
            {
                if (key.Value >= numbOfOccurrences)
                {
                    list.Add(key.Key);
                }
            }
            
            list.Sort();
            return list;
        }

        private static void DisplayDictionary(Dictionary<char, int> starters)
        {
            foreach (var key in starters)
            {
                Console.WriteLine($"Key: {key}  Value: {key.Value}");
            }
        }

        private static Dictionary<char, int> CreateDictionary(List<string> list)
        {
            Dictionary<char, int> starters = new Dictionary<char, int>();
            
            foreach (string str in list)
            {
                if (String.IsNullOrEmpty(str) == false)
                {
                    string lowerCaseString = str.ToLower();
                    
                    if (starters.ContainsKey(lowerCaseString[0]) == false)
                    {
                        starters.Add(lowerCaseString[0], 1);
                    }
                    else
                    {
                        starters[lowerCaseString[0]]++;
                    }
                }
            }

            return starters;
        }
    }
}
