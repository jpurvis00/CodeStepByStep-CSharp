
/* Write a method named IsKeithNumber that accepts an integer and returns true if that number is a "Keith number". A "Keith number" is defined as any n-digit integer that appears in the sequence that starts off with the number's n digits and then continues such that each subsequent number is the sum of the preceding n. (This is not unlike the classic Fibonacci sequence.) All one-digit numbers are trivially Keith numbers. The number 7385 is also a Keith number, because the following sequence ends up back at 7385:

7, 3, 8, 5, 23, 39, 75, 142, 279, 535, 1031, 1987, 3832, 7385
The sequence starts out 7, 3, 8, 5, because those are the digits making up 7385. Each number after that is the sum of the four numbers that precede it (four, because 7385 has four digits). So the fifth number is the sum of 7+3+8+5, or 23. The sixth number is 3+8+5+23, or 39. And so on, until we eventually get back to 7385, which makes 7385 a Keith number.

You may use a single List or List as auxiliary storage. Your method should not loop infinitely; if you become sure that the number is not a Keith number, stop searching and immediately return false.
*/

/* I don't like this solution. It seems way too complicated. Need to come back and redo. */

using Dumpify;

namespace CodeStepByStep_CSharp.Collections.List
{
    public class IsKeithNumber
    {
        public static void RunIsKeithNumber()
        {
            //int origNumb = 7385;
            //int origNumb = 73;
            int origNumb = 72;
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
                    for (int i = 0; i < 3; i++)
                    {
                        sum += numbers[k + 1];
                        k++;
                    }
                    k -= 2;
                    numbers.Add(sum);
                }
                //This takes care of ints that have less than 3 places
                else
                {
                    for (int i = 0; i < numbers.Count - 1; i++)
                    {
                        sum += numbers[k + 1];
                        k++;
                    }
                    k--;
                    numbers.Add(sum);

                    //Once we get to an list with 4 ints, we will hit the if statement and start
                    //using that for loop. We need to start k back at 0 to start our addition at the
                    //first place in the list.
                    if (numbers.Count >= 4)
                    {
                        k = 0;
                    }
                }
            }

            numbers.DumpConsole();

            if (numbers.Last() == origNumb)
            {
                Console.WriteLine("This is a Keith Number!");
            }
            else
            {
                Console.WriteLine("This is a NOT a Keith Number!");
            }
        }
    }
}
