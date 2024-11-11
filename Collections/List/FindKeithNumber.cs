/* Write a method named FindKeithNumbers that accepts minimum and maximum integers as parameters and prints all of the "Keith numbers in that range (inclusive) in the format shown below. See previous program isKeithNumber to learn the definition of a "Keith number." If the given range contains no Keith numbers, print no output. For example, the call of FindKeithNumbers(47, 742); would print the following output:

47: {4, 7, 11, 18, 29, 47}
61: {6, 1, 7, 8, 15, 23, 38, 61}
75: {7, 5, 12, 17, 29, 46, 75}
197: {1, 9, 7, 17, 33, 57, 107, 197}
742: {7, 4, 2, 13, 19, 34, 66, 119, 219, 404, 742}
*/

using Dumpify;

namespace CodeStepByStep_CSharp.Collections.List
{
    public class FindKeithNumber
    {
        public static void RunFindKeithNumber()
        {
            int min = 47;
            int max = 742;
            Dictionary<int, List<int>> results = new();

            results = IsKeithNumber(min, max);
            //results.DumpConsole();
        }

        private static Dictionary<int, List<int>> IsKeithNumber(int min, int max)
        {
            Dictionary<int, List<int>> allKeithNumbers = new();

            for (int i = min; i < max; i++)
            {
                int origNumb = i;
                int numb = origNumb;
                List<int> numbers = new();
                int j = 0;
                int k = 0;

                //Seperate the digits of the integer and put them in a list.
                while (numb / 10 >= 1)
                {
                    numbers.Insert(j, numb % 10);
                    numb /= 10;
                    j++;
                }

                numbers.Add(numb);

                //Reverse the list so that it is now in the same order as the orig integer
                numbers.Reverse();
                int sum = numbers.First();

                //We can stop if the sum is > than than the orig integer. That means it's not a Keith #.
                while (sum != origNumb && sum <= origNumb)
                {
                    //set sum to whatever place in the list we are in. This should be the first position
                    //for adding together 4 ints.
                    if (k >= 0)
                    {
                        sum = numbers[k];
                    }

                    //This takes care of ints that have 4 places or more
                    if (numbers.Count >= 4)
                    {
                        for (int c = 0; c < 3; c++)
                        {
                            if (k + 1 < numbers.Count)
                            {
                                sum += numbers[k + 1];
                                k++;
                            }
                        }
                        //k -= 2;
                        numbers.Add(sum);
                    }
                    //This takes care of ints that have less than 3 places
                    else
                    {
                        for (int c = 0; c < numbers.Count - 1; c++)
                        {
                            if (k + 1 < numbers.Count)
                            {
                                sum += numbers[k + 1];
                                k++;
                            }
                        }
                        //k--;
                        numbers.Add(sum);

                        //Once we get to an list with 4 ints, we will hit the if statement and start
                        //using that for loop. We need to start k back at 0 to start our addition at the
                        //first place in the list.
                        //if (numbers.Count >= 4)
                        //{
                        //    k = 0;
                        //}
                    }
                }


                if (numbers.Last() == origNumb)
                {
                    numbers.DumpConsole();
                    Console.WriteLine("This is a Keith Number!");
                    allKeithNumbers.Add(origNumb, numbers);
                }
                //else
                //{
                //    Console.WriteLine("This is a NOT a Keith Number!");
                //}
            }

            return allKeithNumbers;
        }
    }
}
