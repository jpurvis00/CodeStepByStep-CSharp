
//Write a method named GetMajorityLastName that accepts as its parameter a
//dictionary from strings to strings; the keys of the dictionary represent
//first names and the values represent last names. If there is a single
//common last name that is present in more than half of the key/value pairs
//in the dictionary passed in (a "majority" last name), your method should
//return that last name. If there is no majority last name, your method
//should return the string "?" .

//For example, if the dictionary contains the following key/value pairs,
//the majority last name is "Smith" because it occurs 5 times, which is more
//than half of the nine pairs in the dictionary. Therefore your method would return "Smith".

//{{"Hal", "Perkins"}, { "Mark", "Smith"}, { "Mike", "Smith"}, { "Stuart", "Reges"},
//{ "David", "Smith"}, { "Jean", "Reges"}, { "Geneva", "Smith"}, { "Amie", "Smith"}, { "Bruce", "Reges"}}
//The following dictionaries don't have any majority last name because no last
//name occurs strictly greater than half the time. Therefore when passed either
//of the dictionaries below, your method would return "?" .

//{{"Marty", "Stepp"}, { "Mehran", "Sahami"}, { "Keith", "Schwarz"}, { "Cynthia", "Lee"}, { "Yogurt", "Schwarz"}}
//{ { "Tywin", "Lannister"}, { "Rob", "Stark"}, { "Sansa", "Stark"}, { "Tyrion", "Lannister"} }
//If the dictionary that contains only one key/value pair, that pair's value
//is the majority last name. An empty dictionary does not have any majority last name.

//Constraints: You may declare at most one auxiliary data structure to help you
//solve this problem. Do not modify the dictionary that is passed in to your method as a parameter.



namespace CodeStepByStep_CSharp.Collections.Dictionary
{
    public class GetMajorityLastName
    {
        public static string RunGetMajorityLastName(Dictionary<string, string> names)
        {
            string result = String.Empty;

            var lastNames = CreateLastNameDict(names);
            result = FindMostCommonLastName(lastNames, names.Count);

            return result;
        }

        private static string FindMostCommonLastName(Dictionary<string, int> lastNames, int dictionaryCount)
        {
            string mostCommonLastName = String.Empty;
            int highestNumber = 0;

            if (lastNames == null || lastNames.Count == 0)
            {
                return "?";
            }

            if(lastNames.Count == 1)
            {
                return lastNames.First().Key;
            }

            foreach(var name in lastNames)
            {
                if(name.Value > highestNumber)
                {
                    highestNumber = name.Value;
                    mostCommonLastName = name.Key;
                }
            }

            if(highestNumber < dictionaryCount / 2)
            {
                mostCommonLastName = "?";
            }

            return mostCommonLastName;
        }

        private static Dictionary<string, int> CreateLastNameDict(Dictionary<string, string> names)
        {
            Dictionary<string, int> lastNames = new Dictionary<string, int>();

            foreach(var name in names)
            {
                if(lastNames.ContainsKey(name.Value) == false)
                {
                    lastNames.Add(name.Value, 1);
                }
                else
                {
                    lastNames[name.Value]++;
                }
            }

            return lastNames;
        }
    }
}
