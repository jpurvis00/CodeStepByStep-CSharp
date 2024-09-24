
//Write a method named LastNamesByAge that accepts three parameters:
//1) a SortedDictionary where each key is a person's full name (a string)
//and the associated value is that person's age (an integer);
//2) an integer for a minimum age; and 3) an integer for a max age.

//Your method should return a new dictionary with information about people with ages between the min and max, inclusive.

//In your result map, each key is an integer age, and the value for
//that key is a string with the last names of all people at that age,
//separated by "and" if there is more than one person of that age.
//The order of names for a given age should be in the order they occurred
//in the parameter map. Include only ages between the min and max inclusive,
//where there is at least one person of that age in the parameter map.
//If the dictionary passed is empty, or if there are no people in the
//dictionary between the min/max ages, return an empty dictionary.

//Some names are in the format "first last" such as "Jane Doe". But a name
//could have more tokens, such as "Oscar de la Hoya", or could contain just a
//single token, such as "Cher". For example, if a dictionary named ages stores
//the following key/value pairs:

//{
// { "Allison L. Smith", 18}, { "Benson Kai Lim", 48}, { "David L Shaw", 20}, { "Erik Thomas Jones", 20},
// { "Galen Wood", 15}, { "Madonna", 25}, { "Helene Q. Martin", 40}, { "Janette Siu", 18},
// { "Jessica K. Miller", 35}, { "Marty Douglas Stepp", 35}, { "Paul Beame", 28}, { "Sara de la Pizza", 15},
// { "Stuart T. Reges", 98}, { "Tyler Rigs", 6}, { "Prince", 20}
//}

//The call of LastNamesByAge(ages, 16, 25) should return the following dictionary:
//{ { 18, "Smith and Siu"}, { 20, "Shaw and Jones and Prince"}, { 25, "Madonna"} }

//For the same map, the call of LastNamesByAge(ages, 20, 40) should return the following dictionary:
//{ { 20, "Shaw and Jones and Prince"}, { 25, "Young"}, { 28, "Beame"}, { 35, "Miller and Stepp"}, { 40, "Martin"} }

//Constraints: Obey the following restrictions in your solution.
//You will need to construct a dictionary to store your results,
//but you may not use any other structures (arrays, lists, etc.) as
//auxiliary storage. (You can have as many simple variables as you like.)
//You should not modify the contents of the dictionary passed to your method.
//Declare your method in such a way that any caller can be sure that this will not happen.
//Your solution should run in no worse than O(N log N) time, where N
//is the number of pairs in the dictionary.






namespace CodeStepByStep_CSharp.Collections.Dictionary
{
    public class LastNamesByAge
    {

        private static Dictionary<int, string> lastNamesByAge = new();

        public static void RunLastNamesByAge()
        {
            Dictionary<string, int> names = new()
            {
             { "Allison L. Smith", 18}, { "Benson Kai Lim", 48}, { "David L Shaw", 20}, { "Erik Thomas Jones", 20},
             { "Galen Wood", 15}, { "Madonna", 25}, { "Helene Q. Martin", 40}, { "Janette Siu", 18},
             { "Jessica K. Miller", 35}, { "Marty Douglas Stepp", 35}, { "Paul Beame", 28}, { "Sara de la Pizza", 15},
             { "Stuart T. Reges", 98}, { "Tyler Rigs", 6}, { "Prince", 20}
            };

            int minAge = 20;
            int maxAge = 40;

            CreateNewDictionary(names, minAge, maxAge);

            DisplayDictionary();
        }

        private static void DisplayDictionary()
        {
            foreach (KeyValuePair<int, string> item in lastNamesByAge)
            {
                Console.WriteLine($"age: {item.Key} - names: {item.Value}");
            }
        }

        private static void CreateNewDictionary(Dictionary<string, int> names, int minAge, int maxAge)
        {
            foreach (KeyValuePair<string, int> item in names)
            {
                if (item.Value >= minAge && item.Value <= maxAge)
                {
                    string lastName = item.Key.Split(' ').Last();

                    if (!lastNamesByAge.ContainsKey(item.Value))
                    {
                        lastNamesByAge.Add(item.Value, lastName);
                    }
                    else
                    {
                        lastNamesByAge[item.Value] += " and " + lastName;
                    }
                }
            }
        }































        //private Dictionary<string, int> _names { get; set; } = new Dictionary<string, int>();

        //public LastNamesByAge(Dictionary<string, int> names)
        //{
        //    _names = names; 
        //}

        //public void RunLastNamesByAge(int minAge, int maxAge)
        //{
        //    Dictionary<int, List<string>> namesByAge = CreateNewDictionary(minAge, maxAge);
        //    DisplayDictionary(namesByAge);

        //}

        //private Dictionary<int, List<string>> CreateNewDictionary(int minAge, int maxAge)
        //{
        //    Dictionary<int, List<string>> namesByAge = new Dictionary<int, List<string>>();

        //    foreach (var kvp in _names)
        //    {
        //        if (kvp.Value >= minAge && kvp.Value <= maxAge)
        //        {
        //            string lastName = kvp.Key.Split(' ')[kvp.Key.Split(' ').Length - 1];

        //            if (namesByAge.ContainsKey(kvp.Value) == false)
        //            {
        //                namesByAge.Add(kvp.Value, new List<string> { lastName });
        //            }
        //            else
        //            {
        //                namesByAge[kvp.Value].Add(lastName);
        //            }
        //        }
        //    }

        //    return namesByAge;
        //}

        //private void DisplayDictionary(Dictionary<int, List<string>> namesByAge)
        //{
        //    foreach(var kvp in namesByAge)
        //    {
        //        Console.Write($"{ kvp.Key }, ");

        //        for (int i = 0; i < kvp.Value.Count; i++)
        //        {
        //            Console.Write($"{kvp.Value[i]}");
        //            
        //            if (i < kvp.Value.Count - 1)
        //            {
        //                Console.Write(" and ");
        //            }
        //        }
        //        Console.WriteLine();
        //    }
        //}
    }
}
