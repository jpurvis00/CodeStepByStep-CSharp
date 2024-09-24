
//Write a method IsUnique that accepts a Dictionary from strings to strings
//as a parameter and returns true if no two keys map to the same value (and
//false if any two or more keys do map to the same value). For example,

//calling your method on the following dictionary would return true:
//{ { "Marty", "Stepp"}, { "Stuart", "Reges"}, { "Jessica", "Miller"}, { "Amanda", "Camp"}, { "Hal", "Perkins"} }

//Calling it on the following dictionary would return false, because of two dictionarypings for Perkins and Reges:
//{ { "Kendrick", "Perkins"}, { "Stuart", "Reges"}, { "Jessica", "Miller"}, { "Bruce", "Reges"}, { "Hal", "Perkins"} }

//The empty dictionary is considered to be unique, so your method should return true if passed an empty dictionary.





namespace CodeStepByStep_CSharp.Collections.Dictionary
{
    public class IsUnique
    {
        public static void RunIsUnique()
        {
            Dictionary<string, string> dict1 = new() {
                { "Marty", "Stepp" }, { "Stuart", "Reges" }, { "Jessica", "Miller" }, { "Amanda", "Camp" }, { "Hal", "Perkins" }
            };

            Dictionary<string, string> dict2 = new() {
                { "Kendrick", "Perkins" }, { "Stuart", "Reges" }, { "Jessica", "Miller" }, { "Bruce", "Reges" }, { "Hal", "Perkins" }
            };

            var dupes = dict2
                            .GroupBy(values => values.Value)
                            .Where(group => group.Count() > 1);

            bool result = !dupes.Any();

            Console.WriteLine(result);
            //Dictionary<string, string> dict3 = new();

            //Dictionary<string, int> resultsDict = new();

            //resultsDict = CreateNewDictionary(dict3, resultsDict);
            //bool isUnique = IsDictUnique(resultsDict);

            //Console.WriteLine(isUnique);
        }

        private static bool IsDictUnique(Dictionary<string, int> resultsDict)
        {
            return resultsDict.Count == 0 ? true : !resultsDict.Max(x => x.Value > 1);
        }

        private static Dictionary<string, int> CreateNewDictionary(Dictionary<string, string> dict1, Dictionary<string, int> resultsDict)
        {

            foreach (KeyValuePair<string, string> item in dict1)
            {
                if (!resultsDict.ContainsKey(item.Value))
                {
                    resultsDict.Add(item.Value, 1);
                }
                else
                {
                    resultsDict[item.Value] += 1;
                }
            }

            return resultsDict;
        }


























        //public static bool RunIsUnique(Dictionary<string, string> dict)
        //{
        //    var duplicates = dict
        //                         .GroupBy(pair => pair.Value)
        //                         .Where(group => group.Count() > 1);
        //    
        //    if(duplicates.Count() > 0)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}
    }
}
