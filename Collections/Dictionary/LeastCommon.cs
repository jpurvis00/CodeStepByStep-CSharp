
//Write a method LeastCommon that accepts a Dictionary whose keys are strings
//and whose values are integers as a parameter and returns the integer value
//that occurs the fewest times in the dictionary. For example, if a dictionary
//named m contains {{"Alyssa", 22}, { "Char", 25}, { "Dan", 25}, { "Jeff", 20},
//{ "Kasey", 20}, { "Kim", 20}, { "Mogran", 25}, { "Ryan", 25}, { "Stef", 22}},
//the call of LeastCommon(m) returns 22. If there is a tie, return the smaller
//integer value. If the dictionary is empty, throw an ArgumentException.


using System.Runtime.InteropServices;

namespace CodeStepByStep_CSharp.Collections.Dictionary
{
    public class LeastCommon
    {
        public static int RunLeastCommon(Dictionary<string, int> m)
        {
            Dictionary<int, int> leastCommonNumber = CreateDictionary(m); 
            return GetSmallestValue(leastCommonNumber);
        }

        public static Dictionary<int, int> CreateDictionary(Dictionary<string, int> m)
        {
            Dictionary<int, int> leastCommon = new Dictionary<int, int>();

            foreach (var kvp in m)
            {
                if (leastCommon.ContainsKey(kvp.Value) == false)
                {
                    leastCommon.Add(kvp.Value, 1);
                }
                else
                {
                    leastCommon[kvp.Value]++;
                }
            }

            return leastCommon;
        }
        
        private static int GetSmallestValue(Dictionary<int, int> leastCommonNumber)
        {
            int smallest = -1;
            int value = 0;

            try
            {

                if (leastCommonNumber.Count == 0)
                {
                    throw new ArgumentException("Error: The Dictionary is empty.");
                }
            }
            catch (Exception e)
            {
                value = -1;
                Console.WriteLine(e.Message);
                Environment.Exit(1);
            }

            foreach(var kvp in leastCommonNumber)
            {
                if (smallest == -1)
                {
                    smallest = kvp.Value;
                    value = kvp.Key;
                }

                if (kvp.Value < smallest)
                {
                    smallest = kvp.Value;
                    value = kvp.Key;
                }
                else if(kvp.Value == smallest)
                {
                    if (kvp.Key < value)
                    {
                        value = kvp.Key;
                    }
                }
            }

            return value;
        }
    }
}
