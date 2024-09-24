
using Dumpify;

//Write a method named Rarest that accepts a SortedDictionary from strings
//to strings as a parameter and returns the value that occurs least frequently
//in the dictionary. If there is a tie, return the value that comes earlier in
//ABC order. For example, if a variable called dict containing the following elements:

//{
// { "Alyssa", "Harding"}, { "Char", "Smith"}, { "Dan", "Smith"}, { "Jeff", "Jones"}, { "Kasey", "Jones"},
// { "Kim", "Smith"}, { "Morgan", "Jones"}, { "Ryan", "Smith"}, { "Stef", "Harding"}
//}

//Then a call of Rarest(dict) would return "Harding" because that value occurs 2
//times, fewer than any other. Note that we are examining the values in the
//dictionary, not the keys. If the dictionary passed is empty, throw an ArgumentException.

//Constraints: Obey the following restrictions in your solution.

//You may create one additional data structure (stack, queue, set, dictionary, etc.)
//as auxiliary storage. (You can have as many simple variables as you like.)
//You should not modify the contents of the dictionary passed to your method.
//Declare your method in such a way that any caller can be sure that this will not happen.
//Your solution should run in no worse than O(N log N) time, where N is the number of pairs in the dictionary.

namespace CodeStepByStep_CSharp.Collections.Dictionary
{

    public class Rarest
    {
        public static Dictionary<string, int> namesResults = new();

        public static void RunRarest()
        {
            Dictionary<string, string> names2 = new();
            Dictionary<string, string> names = new()
            {
                { "Alyssa", "Harding"}, { "Char", "Smith"}, { "Dan", "Smith"}, { "Jeff", "Jones"}, { "Kasey", "Jones"},
                { "Kim", "Smith"}, { "Morgan", "Jones"}, { "Ryan", "Smith"}, { "Stef", "Harding"}
            };

            if (names.Count() == 0)
            {
                throw new ArgumentException("The dictionary is empty.");
            }

            foreach (KeyValuePair<string, string> name in names)
            {
                if (!namesResults.ContainsKey(name.Value))
                {
                    namesResults.Add(name.Value, 1);
                }
                else
                {
                    namesResults[name.Value] += 1;
                }
            }

            string rarestName = namesResults.Aggregate((l, r) => l.Value < r.Value ? l : r).Key;

            namesResults.DumpConsole();
            Console.WriteLine($"Rarest name: {rarestName}");
        }
    }






























    //public class Rarest
    //{
    //    private  Dictionary<string, string> _names { get; set; }

    //    public Rarest(Dictionary<string, string> dict)
    //    {
    //        _names = dict; 
    //    }
    //    
    //    public string RunRarest()
    //    {
    //        try
    //        {
    //            if (_names.Count <= 0)
    //            {
    //                throw new ArgumentException("There was a problem with the dictionary you passed in");
    //            }

    //            Dictionary<string, int> rarestNames = new Dictionary<string, int>();
    //            string? rarest = string.Empty;

    //            foreach(var kvp in _names)
    //            {
    //                if (rarestNames.ContainsKey(kvp.Value) == false)
    //                {
    //                    rarestNames.Add(kvp.Value, 1);
    //                }
    //                else
    //                {
    //                    rarestNames[kvp.Value]++;
    //                }
    //            }

    //            rarest =  rarestNames.Min(m => m.Key);

    //            return rarest; 
    //        }
    //        catch (Exception ex)
    //        {
    //            throw new ArgumentException(ex.Message);
    //        }
    //    }
    //}
}
