
//Write a method named HasDuplicateValue that accepts a SortedDictionary from
//strings to strings as a parameter and returns true if any two keys map to the
//same value. For example, if a dictionary named m stores {{"Marty", "Stepp"},
//{ "Stuart", "Reges"}, { "Jessica", "Miller"}, { "Amanda", "Camp"},
//{ "Meghan", "Miller"}, { "Hal", "Perkins"}}, the call of HasDuplicateValue(m) would
//return true because both "Jessica" and "Meghan" map to the value "Miller".
//Return false if passed an empty or one-element map. Do not modify the dictionary passed in.

namespace CodeStepByStep_CSharp.Collections.Dictionary
{
    public class HasDuplicateValue
    {
        public static bool RunHasDuplicateValue(Dictionary<string, string> names)
        {
            string prevLastName = "";

            foreach (var name in names)
            {
                if (prevLastName.Equals(name.Value))
                {
                    return true;
                }

                prevLastName = name.Value;
            }

            return false;
        }
    }
}
