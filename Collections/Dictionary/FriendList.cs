
//Write a method named FriendList that accepts a file name as a
//parameter and reads friend relationships from a file and stores
//them into a compound collection that is returned. You should
//create a dictionary where each key is a person's name from the file,
//and the value associated with that key is a setof all friends of
//that person. Friendships are bi-directional: if Marty is friends
//with Danielle, Danielle is friends with Marty.

//The file contains one friend relationship per line, consisting of two names.
//The names are separated by a single space. You may assume that the file
//exists and is in a valid proper format. If a file named buddies.txt looks like this:

//Marty Cynthia
//Danielle Marty
//Jeff Steph
//Steph Abby
//Then the call of FriendList("buddies.txt") should return a dictionary with the following contents:

//{ { "Cynthia", { "Marty"} }, { "Danielle", { "Marty"} }, { "Marty", { "Cynthia", "Danielle"} } }
//Constraints:

//You may open and read the file only once. Do not re-open it or rewind the stream.
//You should choose an efficient solution. Choose data structures intelligently and use them properly.
//You may create one collection (list, set, dictionary, etc.) or nested/compound
//structure as auxiliary storage. A nested structure, such as a set of lists,
//counts as one collection. (You can have as many simple variables as you like, such as ints or strings.)



namespace CodeStepByStep_CSharp.Collections.Dictionary
{
    public class FriendList
    {
        public static void RunFriendList()
        {
            Dictionary<string, List<string>> friends = new();
            string fileLocation = @"C:\Users\jeffp\source\repos\CodeStepByStep-CSharp\Collections\Dictionary\Buddies.txt";
            string[] lines = File.ReadAllLines(fileLocation);


            friends = CreateDictionary(friends, lines);

            friends = MatchFriends(friends, lines);

            foreach (var friend in friends)
            {
                Console.Write($"{{ \"{friend.Key}\", ");//{friend.Value}\" }} }}");

                foreach (var person in friend.Value)
                {
                    Console.Write($"{{ \"{person} \" }}, ");
                }
                Console.Write($"}}\n");
            }
        }

        private static Dictionary<string, List<string>> MatchFriends(Dictionary<string, List<string>> friends, string[] lines)
        {
            string[] names;
            foreach (var line in lines)
            {
                if (line == null)
                {
                    break;
                }
                else
                {
                    names = line.Split(' ');
                }

                if (friends.ContainsKey(names[1]))
                {
                    if (!friends[names[1]].Contains(names[0]))
                    {
                        friends[names[1]].Add(names[0]);
                    }
                }

                if (friends.ContainsKey(names[0]))
                {
                    if (!friends[names[0]].Contains(names[1]))
                    {
                        friends[names[0]].Add(names[1]);
                    }
                }
            }

            return friends;
        }

        private static Dictionary<string, List<string>> CreateDictionary(Dictionary<string, List<string>> friends, string[] lines)
        {
            string[] names;
            foreach (var line in lines)
            {
                if (line == null)
                {
                    break;
                }
                else
                {
                    names = line.Split(' ');
                }


                if (!friends.ContainsKey(names[0]))
                {
                    friends.Add(names[0], new List<string> { names[1] });
                }

                if (!friends.ContainsKey(names[1]))
                {
                    friends.Add(names[1], new List<string> { names[0] });
                }
            }

            return friends;
        }






























        //public static void RunFriendList(string fileName)
        //{
        //    Dictionary<string, List<string>> friends = new Dictionary<string, List<string>>();

        //    using(StreamReader sr = new StreamReader(fileName))
        //    {
        //        string line;
        //        while ((line = sr.ReadLine()) != null)
        //        {
        //            CreateFriendsList(friends, line);
        //        }
        //    }
        //}

        //private static void CreateFriendsList(Dictionary<string, List<string>> friends, string line)
        //{
        //    string[] names = line.Split(' ');

        //    CreateDictEntryForEachFriend(friends, names);
        //    LinkFriends(friends, names);
        //}

        //private static void LinkFriends(Dictionary<string, List<string>> friends, string[] names)
        //{
        //    if (friends.ContainsKey(names[0]) == true)
        //    {
        //        friends[names[0]].Add(names[1]);
        //    }
        //    
        //    if (friends.ContainsKey(names[1]) == true)
        //    {
        //        friends[names[1]].Add(names[0]);
        //    }
        //}

        //private static void CreateDictEntryForEachFriend(Dictionary<string, List<string>> friends, string[] names)
        //{
        //    for(int i = 0; i < names.Length; i++)
        //    {
        //        if (friends.ContainsKey(names[i]) == false)
        //        {
        //            friends.Add(names[i], new List<string>());
        //        }
        //    }
        //}
    }
}
