

//Write a method named BiggestFamily that reads an input file of people's
//names and prints information about which family has the most people in it.
//Your method accepts a string parameter representing a filename of input.

//The input file contains a collection of names, one per line, in the format
//of the example shown at right. Each line of the file contains a first name (given name),
//a single space, and a last name (surname / family name). For example, in the name "Ned Stark",
//the word "Ned" is the first name and "Stark" is the last name. You may assume
//that every line follows this exact format and that first and last names are single words.

//Jon Snow
//Ned Stark
//Gregor Clegane
//Cersei Lannister
//Tyrion Lannister
//Sandor Clegane
//Jaime Lannister
//Catelyn Stark
//Theon Greyjoy
//Arya Stark
//Cersei Smith
//Ned Jones

//Your method should open and read the contents of this input file and figure out
//which last name(s) occur most frequently in the data, and print the members of
//that family in ABC order in exactly the format shown below.

//If multiple families are tied for the most members, print each of the tied
//families in the same format. For example, in the data at right, the largest
//families are Stark and Lannister, each of which has 3 members listed, so your
//method should print the Lannisters in ABC order and then the Starks in ABC order.

//For example, if the input above is in families.txt, then the call of
//BiggestFamily("families.txt"); should print:

//Lannister family: Cersei Jaime Tyrion
//Stark family: Arya Catelyn Ned

//It is possible that more than two families might tie for the most members.
//One example of such a case is if every person in the file has a different
//last name. In such a case, you should print all of the tying families in
//this same format.

//Assumptions: You may assume that the file exists, and that it contains at
//least one name, that every line of input in the file is in the exact valid
//format described above, and that no two lines of the file will be exactly
//the same (though a given first or last name might occur multiple times).

//Constraints:

//- You may open and read the file only once. Do not re-open it or rewind the stream.
//- You should choose an efficient solution. Choose data structures intelligently and use them properly.
//- You may create up to two collections (stack, queue, set, map, etc.) or nested/compound
//structure as auxiliary storage. A nested structure, such as a set of lists, counts as
//one collection. A temporary collection variable that is merely a replica or reference
//to some other collection (such as, Stack v = myQueue.Dequeue();) is fine and does
//not count as a second structure. (You can have as many simple variables as you like, such as ints or strings.)




namespace CodeStepByStep_CSharp.Collections.Dictionary
{
    public class BiggestFamily
    {
        public static void GetBiggestFamily()
        {
            Dictionary<string, List<string>> families = new Dictionary<string, List<string>>();
            string fileLocation = @"C:\\Users\\jeffp\\source\\repos\\CodeStepByStep-CSharp\\Collections\\Dictionary\\Names.txt";
            List<string> mostFamilyMembers = new List<string>();

            IEnumerable<string> lines = File.ReadLines(fileLocation);

            foreach (string line in lines)
            {
                string[] name = line.Split(' ');

                if (!families.ContainsKey(name[1]))
                {
                    families.Add(name[1], new List<string>());
                    families[name[1]].Add(name[0]);
                }
                else
                {
                    families[name[1]].Add(name[0]);
                }
                //Console.WriteLine(line);
            }

            int biggestFamily = FindEntryWithMostFamilyMembers(families);

            DisplayBiggestFamilies(biggestFamily, families);

        }

        private static void DisplayBiggestFamilies(int biggestFamily, Dictionary<string, List<string>> families)
        {
            foreach (var family in families)
            {
                if (family.Value.Count == biggestFamily)
                {
                    int i = 1;
                    Console.WriteLine($"Family: {family.Key}");

                    foreach (var name in family.Value)
                    {
                        if (i < biggestFamily)
                        {
                            Console.Write($"{name}, ");
                        }
                        else
                        {
                            Console.Write($"{name} ");
                        }
                        i++;
                    }
                    Console.WriteLine("\n");
                }
            }
        }

        private static int FindEntryWithMostFamilyMembers(Dictionary<string, List<string>> families)
        {
            List<string> mostFamilyMembers = new List<string>();
            int count = 0;

            foreach (var family in families)
            {
                if (family.Value.Count > count)
                {
                    count = family.Value.Count;
                }
            }

            return count;
        }























        //public StreamReader reader;

        //public BiggestFamily(string fileName)
        //{
        //    reader = new StreamReader(fileName); 
        //}

        //public Dictionary<string, List<string>> Families { get; set; } = new Dictionary<string, List<string>>();

        //public void ReadFile()
        //{
        //    try
        //    {
        //        string line = reader.ReadLine();

        //        while (line != null)
        //        {
        //            InsertIntoDictionary(line);
        //            
        //            line = reader.ReadLine();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Exception" + ex.Message);
        //    }

        //    int biggestFamily = FindBiggestFamily();
        //    DisplayBiggestFamilies(biggestFamily);
        //}

        //private void DisplayBiggestFamilies(int biggestFamily)
        //{
        //    var sortedDictionary = Families.OrderBy(x => x.Key);

        //    foreach(var family in sortedDictionary)
        //    {
        //        if (family.Value.Count == biggestFamily)
        //        {
        //            Console.Write($"{family.Key} family: ");

        //            family.Value.Sort();

        //            foreach (var name in family.Value)
        //            {
        //                Console.Write($"{name} ");
        //            }
        //            Console.WriteLine();
        //        }
        //    }
        //}

        //private int FindBiggestFamily()
        //{
        //    int biggestFamily = 0;

        //    foreach(var family in Families)
        //    {
        //        if (family.Value.Count > biggestFamily)
        //        {
        //            biggestFamily = family.Value.Count;
        //        }
        //    }

        //    return biggestFamily;
        //}

        //private void InsertIntoDictionary(string line)
        //{
        //    string[] names;

        //    names = line.Split(' ');

        //    //Create new dict entry if the last name does not exist as a key
        //    if (Families.ContainsKey(names[1]) == false)
        //    {
        //        Families.Add(names[1], new List<string>());
        //    }

        //    /* If the last name is a key and they first name does not exist in the list,
        //     * add it.
        //     */
        //    if (Families.ContainsKey(names[1]) && (Families[names[1]].Contains(names[0]) == false))
        //    {
        //        Families[names[1]].Add(names[0]);
        //    }
        //}
    }
}
