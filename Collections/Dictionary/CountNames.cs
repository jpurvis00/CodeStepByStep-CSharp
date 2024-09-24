
//Write a console program named CountNames that asks the user for a list of
//names (one per line) until the user enters a blank line (i.e., just presses
//Enter when asked for a name). At that point the program should print out
//how many times each name in the list was entered. A sample run of this
//program is shown below.

//Enter name: Alice
//Enter name: Bob
//Enter name: Alice
//Enter name: Chelsea
//Enter name: Bob
//Enter name: Alice
//Enter name:
//Entry[Alice] has count 3
//Entry [Bob] has count 2
//Entry [Chelsea] has count 1

namespace CodeStepByStep_CSharp.Collections.Dictionary
{
    public class CountNames
    {
        public static Dictionary<string, int> names = new();

        public static void RunCountNames()
        {
            string? name = String.Empty;
            //Dictionary<string, int> names = new ();

            do
            {
                Console.Write("Enter name: ");
                name = Console.ReadLine();

                InsertNameInDict(name);
            } while (name != null && !name.Equals(""));

            PrintNames();
        }

        private static void PrintNames()
        {
            foreach (var name in names)
            {
                Console.WriteLine($"Entry[{name.Key}] has a count of: {name.Value}");
            }
        }

        private static void InsertNameInDict(string? name)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                return;
            }

            if (!names.ContainsKey(name))
            {
                names.Add(name, 1);
            }
            else
            {
                names[name] += 1;
            }
        }
    }












































    //public static void RunCountNames()
    //{
    //    string? name;
    //    Dictionary<string, int> names = new Dictionary<string, int>();

    //    do
    //    {
    //        name = GetUserInput("Enter name: ");
    //        
    //        AddNameToDictionary(names, name);
    //    } while (string.IsNullOrEmpty(name) == false);
    //    
    //    DisplayNames(names);
    //}

    //private static void DisplayNames(Dictionary<string, int> names)
    //{
    //    foreach (var name in names)
    //    {
    //        Console.WriteLine($"Entry [{name.Key}] has count {name.Value}");
    //    }
    //}

    //private static void AddNameToDictionary(Dictionary<string, int> names, string name)
    //{
    //    if (string.IsNullOrEmpty(name) == true)
    //    {
    //        return;
    //    }

    //    if (names.ContainsKey(name) == false)
    //    {
    //        names.Add(name, 1);
    //    }
    //    else
    //    {
    //        names[name] += 1;
    //    }
    //}

    //private static string GetUserInput(string input)
    //{
    //    Console.Write(input);
    //    return Console.ReadLine();
    //}
}
