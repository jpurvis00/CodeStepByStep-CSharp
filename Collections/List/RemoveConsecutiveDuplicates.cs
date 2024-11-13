//Write a method named RemoveConsecutiveDuplicates that accepts as a 
//parameter a List of integers, and modifies it by removing any 
//consecutive duplicates. For example, if a list named v stores 
//{1, 2, 2, 3, 2, 2, 3}, the call of RemoveConsecutiveDuplicates(v); 
//should modify it to store {1, 2, 3, 2, 3}.

using Dumpify;

namespace CodeStepByStep_CSharp.Collections.List
{
    public class RemoveConsecutiveDuplicates
    {
        public static void RunRemoveConsecutiveDuplicates()
        {
            List<int> nonDuplicateList = new() { 1, 2, 2, 3, 2, 2, 3 };

            for (int i = 0; i < nonDuplicateList.Count; i++)
            {
                if (i + 1 == nonDuplicateList.Count)
                {
                    break;
                }

                if (nonDuplicateList[i] == nonDuplicateList[i + 1])
                {
                    nonDuplicateList.RemoveAt(i + 1);
                }
            }

            nonDuplicateList.DumpConsole();
        }
    }
}
