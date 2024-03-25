
//Write a method named RarestAge that accepts as a parameter a Dictionary from
//students' names (strings) to their ages (integers), and returns the least
//frequently occurring age. Consider a dictionary variable named m containing
//the following key/value pairs:

//{{"Char", 45}, { "Dan", 45}, { "Jerry", 23}, { "Kasey", 10}, { "Jeff", 10},
//{ "Elmer", 45}, { "Kim", 10}, { "Ryan", 45}, { "Mehran", 23}}

//Three people are age 10 (Kasey, Jeff, and Kim), two people are age 23
//(Jerry and Mehran), and four people are age 45 (Char, Dan, Elmer, and Ryan).
//So a call of RarestAge(m) returns 23 because only two people are that age.
//If there is a tie (two or more rarest ages that occur the same number of times),
//return the youngest age among them. For example, if we added another pair of
//Steve=23 to the dictionary above, there would now be a tie of three people of
//age 10 (Kasey, Jeff, Kim) and three people of age 23 (Jerry, Mehran, Steve).
//So a call of RarestAge(m) would now return 10 because 10 is the smaller of the
//rarest values. This implies that if every person in the dictionary has a unique age,
//your method would return the smallest of all the ages in the dictionary.

//If the dictionary passed to your method is null or empty, your method should return 0.
//You may assume that no key or value stored in the dictionary is null. Otherwise you
//should not make any assumptions about the number of key/value pairs in the dictionary
//or the range of possible ages that could be in the dictionary.

//Constraints:
//You may create one collection of your choice as auxiliary storage to solve this problem.
//You can have as many simple variables as you like.
//You should not modify the contents of the dictionary passed to your method.




namespace CodeStepByStep_CSharp.Collections.Dictionary
{
    public class RarestAge
    {
        internal static int RunRarestAge(Dictionary<string, int> namesAndAges)
        {
            if (namesAndAges == null || namesAndAges.Count == 0)
            {
                return 0;
            }

            var ageDict = CreateNewDict(namesAndAges);
            return GetLeastAgeOccurrence(ageDict);
        }

        private static Dictionary<int, int> CreateNewDict(Dictionary<string, int> namesAndAges)
        {
            Dictionary<int, int> ageOccurrences = new Dictionary<int, int>();

            foreach (var name in namesAndAges.Values)
            {
                if (ageOccurrences.ContainsKey(name) == false)
                {
                    ageOccurrences.Add(name, 1);
                }
                else
                {
                    ageOccurrences[name]++;
                }
            }

            return ageOccurrences;
        }
        private static int GetLeastAgeOccurrence(Dictionary<int, int> ageDict)
        {
            var smallest = ageDict.First().Value;
            var ageGroup = ageDict.First().Key;

            foreach (var age in ageDict)
            {
                if(age.Value <= smallest)
                {
                    smallest = age.Value;
                    if (age.Key < ageGroup)
                    {
                        ageGroup = age.Key;
                    }
                }
            }

            return ageGroup;
        }
    }
}
