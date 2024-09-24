using Dumpify;

//Write a method named PostalService that helps the postal service sort
//mail for customers based on "ZIP" codes. A ZIP code is an integer that
//represents a given city or region of the USA. Your method accepts two dictionaries as parameters:

//a(customer name → ZIP code) SortedDictionary, where each key is a person's
//full name as a string and each value is that person's numeric ZIP code as
//an integer. For example, the pair "Jon Smith", 12345 would mean that the
//customer named John Smith lives at the ZIP code of 12345.

//a (ZIP code → city) SortedDictionary, where each key is an integer ZIP
//code and each value is the name of the city for that zip code as a string.
//For example, the pair 12345, "Mordor" would mean that the ZIP code 12345
//corresponds to the city of Mordor.
//Your job is to build and return a new SortedDictionary where the keys are
//city names, and values are strings showing the last name (surname) of every
//customer whose ZIP code is in that city.

//In the customer map passed to your method, names are represented in
//"FirstName LastName" format, where the given name (first name) is followed
//by a space and then the surname (last name), such as "Michael Jackson".
//But a name could have more words in it, such as "Oscar de la Hoya", or could
//contain just a single word, such as "Cher". For any name, regardless of how
//many words it contains, the last word in that name is considered to be the
//customer's last name / surname.

//For example, two dictionaries named people and cities might store the following
//pairs, shown in key=value format:

//(1) 'people' customer map:  
//{
//    { "Ally T Obern", 85704}, { "Madonna", 11430}, { "David Q Shaw", 90045}, { "Mike Tom Brooks", 85704},
//   { "Jerry Cain", 11430}, { "Kate Jan Martin", 68052}, { "Jane Su", 68052}, { "Jessica K. R. Miller", 94305},
//   { "Marty Doug Stepp", 95050}, { "Nick T", 94305}, { "Sara de la Pizza", 68052}, { "Stu T. Reges", 94305},
//   { "Prince", 94305}, { "Dany Khaleesi Mother of Dragons Targaryen", 9999999}
//}
//(2) 'cities' ZIP / city map:
//{
//    { 11430, "NewYork"}, { 22222, "Duluth"}, { 68052, "Springfield"}, { 71384, "Omaha"}, { 85704, "Tucson"},
//   { 90045, "Redmond"}, { 94305, "Stanford"}, { 95050, "SantaClara"}, { 9999999, "Westeros"}
//}

//In the result map you must build, each key is a string representing a city name,
//and the associated value is a string with the last names of all people in that
//ZIP code, separated by " and " if there is more than one person in the ZIP code
//in the data. The order names are listed for a given ZIP code does not matter.
//If a given city does not correspond to any people in the customer map, that city
//name should not be included in your result map.

//When passed the dictionaries above, the call of PostalService(people, cities) should return the following dictionary:

//  {
//    { "Tucson", "Obern and Brooks"}, { "NewYork", "Madonna and Cain"}, { "Redmond", "Shaw"},
//   { "Springfield", "Martin and Su and Pizza"}, { "Stanford", "Miller and T and Reges and Prince"},
//   { "SantaClara", "Stepp"}, { "Westeros", "Targaryen"}
//}

//Assumptions: You may assume that ZIP codes will be non-negative, but otherwise you
//should not make any assumptions about the range of numbers you will see as ZIP codes.
//You may assume that names are non-empty strings consisting of at least one character,
//but otherwise you should also not make any assumptions about the length or content of names.
//You may assume that every ZIP code found in the customer map will also be found in the ZIP/city
//map, but not every ZIP/city found in the cities map might be present in the people/customers map.
//If the customer map passed is empty, return an empty dictionary. Otherwise do not make
//assumptions about the size of either map.

//Constraints: You may declare one map to help you solve this problem. (This is the dictionary you will return.)
//You may not declare any other data structures.
//You can have as many simple variables as you like, such as integers or strings.
//Do not modify the dictionaries that are passed in to your method as parameters.


namespace CodeStepByStep_CSharp.Collections.Dictionary
{
    public static class PostalService
    {
        private static Dictionary<string, string> cityNames = new();

        public static void RunPostalService()
        {
            Dictionary<string, int> people1 = new();
            Dictionary<string, int> people = new()
            {
                { "Ally T Obern", 85704}, { "Madonna", 11430}, { "David Q Shaw", 90045}, { "Mike Tom Brooks", 85704},
                { "Jerry Cain", 11430}, { "Kate Jan Martin", 68052}, { "Jane Su", 68052}, { "Jessica K. R. Miller", 94305},
                { "Marty Doug Stepp", 95050}, { "Nick T", 94305}, { "Sara de la Pizza", 68052}, { "Stu T. Reges", 94305},
                { "Prince", 94305}, { "Dany Khaleesi Mother of Dragons Targaryen", 9999999}
            };

            Dictionary<int, string> cities = new()
            {
                { 11430, "NewYork"}, { 22222, "Duluth"}, { 68052, "Springfield"}, { 71384, "Omaha"}, { 85704, "Tucson"},
                { 90045, "Redmond"}, { 94305, "Stanford"}, { 95050, "SantaClara"}, { 9999999, "Westeros"}
            };

            if (people.Count() == 0)
            {
                Console.WriteLine("There are no customers");
            }
            else
            {
                foreach (KeyValuePair<string, int> person in people)
                {
                    if (cities.ContainsKey(person.Value))
                    {
                        CreateCityNamesDict(person, cities, person.Key.Split(' ').Last());
                    }
                }
            }

            cityNames.DumpConsole();
        }

        private static void CreateCityNamesDict(KeyValuePair<string, int> person, Dictionary<int, string> cities, string lastName)
        {
            foreach (KeyValuePair<int, string> city in cities)
            {
                if (person.Value == city.Key)
                {
                    if (!cityNames.ContainsKey(city.Value))
                    {
                        cityNames.Add(city.Value, lastName);
                    }
                    else
                    {
                        cityNames[city.Value] += " and " + lastName;
                    }
                }
            }
        }










































        //public static Dictionary<string, string> results = new Dictionary<string, string>();
        //
        //public static void RunPostalService(Dictionary<string, int> people, Dictionary<int, string> cities)
        //{
        //    CreateKeysForResultsDict(cities);
        //    CreateValueString(people, cities);
        //    var sortedDict = results.OrderBy(x => x.Key);
        //    DisplayResultsDictionary(sortedDict);
        //}

        //private static void CreateKeysForResultsDict(Dictionary<int, string> cities)
        //{
        //    foreach (var kvp in cities)
        //    {
        //        if (results.ContainsKey(kvp.Value) == false)
        //        {
        //            results.Add(kvp.Value, string.Empty); 
        //        }
        //    }
        //}

        //private static void CreateValueString(Dictionary<string, int> people, Dictionary<int, string> cities)
        //{
        //    foreach (var kvp in people)
        //    {
        //        string[] temp = kvp.Key.Split(' ');
        //        string lastName = temp[temp.Count() - 1];

        //        string cityKey = string.Empty;
        //        if (cities.ContainsKey(kvp.Value) == true)
        //        {
        //            cityKey = cities[kvp.Value];
        //        }

        //        if (results.ContainsKey(cityKey) == true)
        //        {
        //            string names = results[cityKey];

        //            if (names.Length <= 0)
        //            {
        //                names = lastName;
        //            }
        //            else
        //            {
        //                names = names + " and " + lastName;
        //            }
        //            results[cityKey] = names;
        //        }
        //    }
        //}

        //private static void DisplayResultsDictionary(IOrderedEnumerable<KeyValuePair<string, string>> sortedDict)
        //{
        //    foreach (var kvp in sortedDict)
        //    {
        //        if (kvp.Value.Length > 0)
        //        {
        //            Console.WriteLine($"key: {kvp.Key}  value: {kvp.Value}");
        //        }
        //    }
        //}
    }
}
