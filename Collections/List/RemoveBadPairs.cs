//Write a method named RemoveBadPairs that accepts as a 
//parameter a List of integers, and removes any adjacent 
//pair of integers in the list if the left element of the 
//pair is larger than the right element of the pair. Every 
//pair's left element is an even-numbered index in the list, 
//and every pair's right element is an odd index in the list. 
//For example, suppose a variable named vec stores the following element values:

//{3, 7, 9, 2, 5, 5, 8, 5, 6, 3, 4, 7, 3, 1}
//We can think of this list as a sequence of pairs:
//
//{3, 7, 9, 2, 5, 5, 8, 5, 6, 3, 4, 7, 3, 1}
//The pairs 9-2, 8-5, 6-3, and 3-1 are "bad" because the left 
//element is larger than the right one, so these pairs should be removed. 
//So the call of RemoveBadPairs(vec); would change the list to store:
//
//{3, 7, 5, 5, 4, 7}
//If the list has an odd length, the last element is not part 
//of a pair and is also considered "bad;" it should therefore be removed by your method.
//
//If an empty list is passed in, the list should still be empty at the end of the call.
//
//Constraints: Do not use any other arrays, lists, or other data structures 
//to help solve this problem, though you can create as many simple variables as you like.

using Dumpify;

namespace CodeStepByStep_CSharp.Collections.List
{
    public class RemoveBadPairs
    {
        public static void RunRemoveBadPairs()
        {
            //List<int> numbs = new() { 3, 7, 9, 2, 5, 5, 8, 5, 6, 3, 4, 7, 3, 1, 8 };
            List<int> numbs = new() { 3, 7, 9, 2, 5, 5, 8, 5, 6, 3, 4, 7, 3, 1, 8, 2, 4, 9 };

            if (numbs.Count % 2 == 1)
            {
                numbs.RemoveAt(numbs.Count - 1);
            }

            for (int i = 0; i < numbs.Count; i++)
            {
                if (i >= numbs.Count - 1)
                {
                    break;
                }

                if (numbs[i] > numbs[i + 1])
                {
                    numbs.RemoveAt(i + 1);
                    numbs.RemoveAt(i);
                    i -= 1; //takes us back to start at the new position of pairs in the reordered list
                }
                else
                {
                    i++; //pair is not bad, skip the next int to start comparing the next pair
                }

            }

            numbs.DumpConsole();
        }
    }
}
