
//Write a method named ByAge that accepts three parameters:
//1) a dictionary where each key is a person's name (a string)
//and the associated value is that person's age (an integer);
//2) an integer for a minimum age; and 3) an integer for a max age.
//Your method should return a new dictionary with information
//about people with ages between the min and max, inclusive.

//In your result dictionary, each key is an integer age, and
//the value for that key is a string with the names of all people
//at that age, separated by "and" if there is more than one person
//of that age. The order of names for a given age should be in alphabetical
//order, such as "Bob and Carl" rather than "Carl and Bob". (This is the
//order in which they naturally occur in the parameter dictionary.)
//Include only ages between the min and max inclusive, where there
//is at least one person of that age in the parameter dictionary.
//If the dictionary passed is empty, or if there are no people in
//the dictionary between the min/max ages, return an empty dictionary.

//For example, if a dictionary named ages stores the following key:value pairs:

//{
//    { "Allison", 18}, { "Benson", 48}, { "David", 20}, { "Erik", 20}, { "Galen", 15}, {
//        "Grace, 25},
// { "Helene", 40}, { "Janette", 18}, { "Jessica", 35}, { "Marty", 35}, { "Paul", 28}, { "Sara", 15},
// { "Stuart", 98}, { "Tyler", 6}, { "Zack", 20}
//    }
//    The call of ByAge(ages, 16, 25) should return the following dictionary:

//{ { 18, "Allison and Janette"}, { 20, "David and Erik and Zack"}, { 25, "Grace"} }
//    For the same dictionary, the call of ByAge(ages, 20, 40) should return the following dictionary:

//{ { 20, "David and Erik and Zack"}, { 25, "Grace"}, { 28, "Paul"}, { 35, "Jessica and Marty"}, { 40, "Helene"} }
//Constraints: Obey the following restrictions in your solution.

//You will need to construct a dictionary to store your results,
//but you may not use any other structures(arrays, lists, etc.)
//as auxiliary storage. (You can have as many simple variables as you like.)
//You should not modify the contents of the dictionary passed to your method.
//Declare your method in such a way that any caller can be sure that this will not happen.
//Your solution should run in no worse than O(N log N) time, where N is the number of pairs in the dictionary.

using System.Runtime.InteropServices;

namespace CodeStepByStep_CSharp.Collections.Dictionary
{
    public class ByAge
    {
        public static Dictionary<int, List<string>> RunByAge(Dictionary<string, int> namesAndAges, int minAge, int maxAge) 
        {
            Dictionary<int, List<string>> agesAndNames = new Dictionary<int, List<string>>();

            foreach (var name in namesAndAges)
            {
                if (agesAndNames.ContainsKey(name.Value) == false)
                {
                    if(name.Value >= minAge && name.Value <= maxAge)
                    {
                        agesAndNames.Add(name.Value, new List<string> { name.Key });
                    }
                }
                else
                {
                    agesAndNames[name.Value].Add(name.Key);
                }
            }

            return agesAndNames;            
        }

        public static void DisplayDictionary(Dictionary<int, List<string>> dict)
        {
            foreach(var name in dict)
            {
                Console.Write($"{name.Key}: ");

                for(int i = 0; i < name.Value.Count; i++)
                {
                    Console.Write($"{name.Value[i]}");

                    if (i + 1 < name.Value.Count)
                    {
                        Console.Write(" and ");
                    }
                }
                Console.WriteLine();
            }    
        }
    }
}
