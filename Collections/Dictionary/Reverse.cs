
//Write a method named Reverse that accepts a dictionary from integers to strings
//as a parameter and returns a new SortedDictionary of strings to integers that
//is the original's "Reverse". The Reverse of a dictionary is defined here to be a
//new dictionary that uses the values from the original as its keys and the keys
//from the original as its values. Since a dictionary's values need not be unique
//but its keys must be, it is acceptable to have any of the original keys as the
//value in the result. In other words, if the original map has pairs (k1, v)
//and (k2, v), the new dictionary must contain either the pair (v, k1) or (v, k2).

//For example, for the following dictionary:

//{ { 42, "Marty"}, { 81, "Sue"}, { 17, "Ed"}, { 31, "Dave"}, { 56, "Ed"}, { 3, "Marty"}, { 29, "Ed"} }
//Your method could return the following new dictionary(the order of the key / value pairs does not matter):

//{ { "Marty", 3}, { "Sue", 81}, { "Ed", 29}, { "Dave", 31} }
//Do not modify the dictionary passed in as the parameter.

namespace CodeStepByStep_CSharp.Collections.Dictionary
{
    public class Reverse
    {
        public static void RunReverse(Dictionary<int, string> reverse)
        {
            Dictionary<string, int> newDict = CreateDictionary(reverse);
            DisplayDictionary(newDict);
        }

        private static Dictionary<string, int> CreateDictionary(Dictionary<int, string> reverse)
        {
            Dictionary<string, int> namesDict = new Dictionary<string, int>();

            foreach (var item in reverse)
            {
                if (namesDict.ContainsKey(item.Value) == false)
                {
                    namesDict.Add(item.Value, item.Key);
                }
            }

            return namesDict;
        }
        private static void DisplayDictionary(Dictionary<string, int> newDict)
        {
            foreach (var item in newDict)
            {
                Console.WriteLine($"Key: {item.Key}     Value: {item.Value}");
            }
        }
    }
}
