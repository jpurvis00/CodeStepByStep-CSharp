
//Write a method named IsSubDictionary that accepts two dictionaries
//from strings to strings as its parameters and returns true if every
//key in the first map is also contained in the second map and maps
//to the same value in the second map.

//For example, given the dictionaries below, dict1 is a sub-map of dict2,
//so the call of IsSubDictionary(dict1, dict2) would return true.
//The order of the parameters does matter, so the call of
//IsSubDictionary(dict2, dict1) would return false.
//But dict3 is not a sub-map of dict2 because the key "Alisha" is not in
//dict2 and also because the key "Smith" does not map to the same value
//as it does in dict2; therefore the call of IsSubDictionary(dict3, dict2)
//would return false. The empty dictionary is considered to be a sub-map of
//every map, so the call of IsSubDictionary(dict4, dict1) would return true.

//dict1: { { "Smith", "949-0504"}, { "Marty", "206-9024"} }
//dict2: { { "Marty", "206-9024"}, { "Hawking", "123-4567"}, { "Smith", "949-0504"}, { "Newton", "123-4567"} }
//dict3: { { "Alisha", "321-7654"}, { "Hawking", "123-4567"}, { "Smith", "888-8888"} }
//dict4: { }

//Constraints: You may not declare any auxiliary data structures in solving this problem.



namespace CodeStepByStep_CSharp.Collections.Dictionary
{
    public class IsSubDictionary
    {

        public static void RunIsSubDictionary()
        {
            Dictionary<string, string> dict1 = new() { { "Smith", "949-0504" }, { "Marty", "206-9024" } };
            Dictionary<string, string> dict2 = new() { { "Marty", "206-9024" }, { "Hawking", "123-4567" }, { "Smith", "949-0504" }, { "Newton", "123-4567" } };
            Dictionary<string, string> dict3 = new() { { "Alisha", "321-7654" }, { "Hawking", "123-4567" }, { "Smith", "888-8888" } };
            Dictionary<string, string> dict4 = new() { };

            bool isSubDictionary = CheckSubDictionary(dict4, dict3);

            Console.WriteLine(isSubDictionary);
        }

        private static bool CheckSubDictionary(Dictionary<string, string> dict1, Dictionary<string, string> dict2)
        {
            if (dict1.Count == 0)
            {
                return true;
            }

            foreach (var item in dict1)
            {
                if (!dict2.ContainsKey(item.Key))
                {
                    return false;
                }
                else
                {
                    if (dict2[item.Key] != item.Value)
                    {
                        return false;
                    }

                }
            }
            return true;
        }




























        //public static bool RunIsSubDictionary(Dictionary<string, string> dict1, Dictionary<string, string> dict2)
        //{
        //    bool isSubDictionary = false;

        //    if (dict1.Count == 0)
        //    {
        //        return true;
        //    }

        //    foreach(var kvp in dict1)
        //    {
        //        if (dict2.ContainsKey(kvp.Key))
        //        {
        //            if(kvp.Value == dict2[kvp.Key])
        //            {
        //                isSubDictionary = true;                        
        //            }
        //            else
        //            {
        //                isSubDictionary = false;
        //            }
        //        }
        //        else
        //        {
        //            isSubDictionary = false;
        //        }
        //    }

        //    return isSubDictionary;
        //}
    }
}
