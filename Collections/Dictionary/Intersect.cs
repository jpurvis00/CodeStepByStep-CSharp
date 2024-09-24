
//Write a method named Intersect that accepts two Dictionarys of strings to
//integers as parameters and that returns a new SortedDictionary whose
//contents are the intersection of the two. The intersection of two maps
//is defined here as the set of keys and values that exist in both maps.
//So if some value K maps to value V in both the first and second map,
//include it in your result. If K does not exist as a key in both maps,
//or if K does not map to the same value V in both maps, exclude that
//pair from your result. For example, consider the following two maps:

//dict { { "Janet", 87}, { "Logan", 62}, { "Whitaker", 46}, { "Alyssa", 100}, { "Stefanie", 80}, { "Jeff", 88}, { "Kim", 52}, { "Sylvia", 95} }
//dict 2 { { "Logan", 62}, { "Kim", 52}, { "Whitaker", 52}, { "Jeff", 88}, { "Stefanie", 80}, { "Brian", 60}, { "Lisa", 83}, { "Sylvia", 87} }
//Calling your method on the preceding maps would return the following new map:

//{ { "Logan", 62}, { "Stefanie", 80}, { "Jeff", 88}, { "Kim", 52} }
//Do not modify the maps passed in as parameters.




namespace CodeStepByStep_CSharp.Collections.Dictionary
{
    public class Intersect
    {
        public static void RunIntersect()
        {
            Dictionary<string, int> intersectDict = new();
            Dictionary<string, int> dict = new()
            {
                { "Janet", 87},
                { "Logan", 62},
                { "Whitaker", 46},
                { "Alyssa", 100},
                { "Stefanie", 80},
                { "Jeff", 88},
                { "Kim", 52},
                { "Sylvia", 95}
            };
            Dictionary<string, int> dict2 = new()
            {
                { "Logan", 62 },
                { "Kim", 52},
                { "Whitaker", 52},
                { "Jeff", 88},
                { "Stefanie", 80},
                { "Brian", 60},
                { "Lisa", 83},
                { "Sylvia", 87}
            };

            intersectDict = CreateDictionary(dict, dict2, intersectDict);
            intersectDict = SortDictionary(intersectDict);
            DisplaySortedDictionary(intersectDict);
        }

        private static Dictionary<string, int> SortDictionary(Dictionary<string, int> intersectDict)
        {
            return intersectDict.OrderBy(x => x.Key).ToDictionary(pair => pair.Key, pair => pair.Value);
        }

        private static void DisplaySortedDictionary(Dictionary<string, int> intersectDict)
        {
            foreach (var item in intersectDict)
            {
                Console.WriteLine($"Key: {item.Key} - Value: {item.Value}");
            }
        }

        private static Dictionary<string, int> CreateDictionary(Dictionary<string, int> dict, Dictionary<string, int> dict2, Dictionary<string, int> intersectDict)
        {
            foreach (var item in dict)
            {
                if (dict2.ContainsKey(item.Key))
                {
                    if (item.Value == dict2[item.Key])
                    {
                        intersectDict.Add(item.Key, item.Value);
                    }
                }
            }

            return intersectDict;
        }



























        //public static void RunIntersect(Dictionary<string, int> dict, Dictionary<string, int> dict2)
        //{

        //    Dictionary<string, int> intersectDictionary = CreateDictionary(dict, dict2);
        //    Dictionary<string, int> sortedDictionary = SortDictionary(intersectDictionary);
        //    DisplaySortedDictionary(sortedDictionary);
        //}

        //private static void DisplaySortedDictionary(Dictionary<string, int> sortedDictionary)
        //{
        //    foreach(var kvp in sortedDictionary)
        //    {
        //        Console.WriteLine($"Dict entry: {kvp.Key} - {kvp.Value}");
        //    }
        //}

        //private static Dictionary<string, int> SortDictionary(Dictionary<string, int> intersectDictionary)
        //{
        //    return intersectDictionary
        //        .OrderBy(x => x.Key)
        //        .ToDictionary(pair => pair.Key, pair => pair.Value);
        //}

        //private static Dictionary<string, int> CreateDictionary(Dictionary<string, int> dict, Dictionary<string, int> dict2)
        //{
        //    Dictionary<string, int> intersectDictionary = new Dictionary<string, int>();
        //    
        //    foreach (var entry in dict2)
        //    {
        //        if (dict.ContainsKey(entry.Key))
        //        {
        //            if (dict[entry.Key] == entry.Value)
        //            {
        //                intersectDictionary.Add(entry.Key, entry.Value);
        //            }
        //        }
        //    }

        //    return intersectDictionary;
        //}
    }
}
