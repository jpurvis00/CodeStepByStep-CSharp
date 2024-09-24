using System;

//Write a method named HasThree that accepts a list of strings as a parameter
//and returns true if any string value occurs at least 3 times in the list.
//For example, in the list {"to", "be", "or", "be", "to", "be", "hamlet"},
//the word "be" occurs 3 times, so your method would return true if passed
//that list. Use a dictionary as auxiliary storage to help solve the problem.
//Do not modify the list that is passed in.



namespace CodeStepByStep_CSharp.Collections.Dictionary
{
    public class HasThree
    {



        public static void Test()
        {
            Dictionary<string, int> wordDict = new();
            string[] words = { "to", "be", "or", "be", "to", "be", "hamlet", "test", "test" };

            foreach (string word in words)
            {
                if (!wordDict.ContainsKey(word))
                {
                    wordDict.Add(word, 1);
                }
                else
                {
                    wordDict[word] += 1;
                }
            }

            foreach (var item in wordDict)
            {
                Console.WriteLine($"Word: {item.Key} occurs {item.Value} times.");

            }
        }





















        //public static bool RunHasThree(string[] input)
        //{
        //    Dictionary<string, int> wordCount = new Dictionary<string, int>();

        //    CreateDictionary(wordCount, input);
        //    return WordOccursThreeTimes(wordCount);
        //}

        //private static bool WordOccursThreeTimes(Dictionary<string, int> wordCount)
        //{
        //    foreach(var word in wordCount)
        //    {
        //        if(word.Value >= 3)
        //        {
        //            return true;
        //        }
        //    }

        //    return false;
        //}

        //private static void CreateDictionary(Dictionary<string, int> wordCount, string[] input)
        //{
        //    foreach (var word in input)
        //    {
        //        if (wordCount.ContainsKey(word) == false)
        //        {
        //            wordCount.Add(word, 1);
        //        }
        //        else
        //        {
        //            wordCount[word]++;
        //        }
        //    }
        //}
    }
}
