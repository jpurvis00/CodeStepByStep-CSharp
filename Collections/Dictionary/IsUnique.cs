
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
        public static bool RunIsUnique(Dictionary<string, string> dict)
        {
            var duplicates = dict
                                 .GroupBy(pair => pair.Value)
                                 .Where(group => group.Count() > 1);
            
            if(duplicates.Count() > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
