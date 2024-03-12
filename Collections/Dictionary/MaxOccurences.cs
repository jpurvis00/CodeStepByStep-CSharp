
//Write a method named MaxOccurrences that accepts a list of integers as a
//parameter and returns the number of times the most frequently occurring
//integer (the "mode") occurs in the list. Solve this problem using a
//dictionary as auxiliary storage.If the list is empty, return 0. Do not
//modify the list passed in as a parameter.



namespace CodeStepByStep_CSharp.Collections.Dictionary
{
    public class MaxOccurences
    {
        public static int RunMaxOccurences(List<int> list)
        {
            Dictionary<int, int> maxNumberDict = CreateNewDictionary(list);
            int maxNumber = GetMaxNumber(maxNumberDict);

            return maxNumber;
        }

        private static Dictionary<int, int> CreateNewDictionary(List<int> list)
        {
            Dictionary<int, int> maxNumber = new Dictionary<int, int>();

            foreach (int n in list)
            {
                if (maxNumber.ContainsKey(n) == false)
                {
                    maxNumber.Add(n, 1);
                }
                else
                {
                    maxNumber[n]++;
                }
            }

            return maxNumber;
        }

        private static int GetMaxNumber(Dictionary<int, int> maxNumberDict)
        {
            int maxNumber = 0, key = 0, count = 0;

            if (maxNumberDict.Count == 0)
            {
                return 0;
            }

            foreach (var kvp in maxNumberDict)
            {
                if(count == 0)
                {
                    maxNumber = kvp.Value;
                }

                if (kvp.Value == maxNumber)
                {
                    if(kvp.Key > key)
                    {
                        key = kvp.Key;
                    }
                    maxNumber = kvp.Value;
                }
                else if (kvp.Value > maxNumber)
                {
                    key = kvp.Key;
                    maxNumber = kvp.Value;
                }

                count++;
            }

            return key;
        }
    } 
}
