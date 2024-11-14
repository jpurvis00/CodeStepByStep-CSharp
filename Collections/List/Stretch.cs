/* Write a method named Stretch that accepts as a parameter a List of integers, 
 * and modifies it to be twice as large, replacing every integer with a pair of integers, 
 * each half the original. If a number in the original list is odd, 
 * then the first number in the new pair should be one higher than the second 
 * so that the sum equals the original number. For example, if a variable named 
 * v refers to a list storing the values {18, 7, 4, 24, 11}, the call of Stretch(v); 
 * should change v to contain {9, 9, 4, 3, 2, 2, 12, 12, 6, 5}. (The number 18 is 
 * Stretched into the pair 9, 9, the number 7 is Stretched into 4, 3, the number 
 * 4 is Stretched into 2, 2, the number 24 is Stretched into 12, 12, and 11 is 
 * Stretched into 6, 5.)
 */

using Dumpify;

namespace CodeStepByStep_CSharp.Collections.List
{
    public class Stretch
    {
        public static void RunStretch()
        {
            List<int> stretchNumbers = new() { 18, 7, 4, 24, 11 };

            for (int i = 0; i < stretchNumbers.Count; i++)
            {
                if (stretchNumbers[i] % 2 == 0)
                {
                    int half = stretchNumbers[i] / 2;
                    stretchNumbers[i] = half;
                    stretchNumbers.Insert(i + 1, half);
                    i++;
                }
                else
                {
                    double half = stretchNumbers[i] / 2.0;
                    stretchNumbers[i] = (int)Math.Ceiling(half);
                    stretchNumbers.Insert(i + 1, (int)Math.Floor(half));
                    i++;
                }
            }

            stretchNumbers.DumpConsole();
        }
    }
}
