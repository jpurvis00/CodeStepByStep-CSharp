
//Write a method named IsHappyNumber that returns whether a given integer is "happy". 
//An integer is "happy" if repeatedly summing the squares of its digits eventually leads to the number 1.
//
//For example, 139 is happy because:
//
//Each number below is squared. Notation did not copy over from problem desc.
//12 + 32 + 92 = 91 1squared + 3squared + 9squared
//92 + 12 = 82
//82 + 22 = 68
//62 + 82 = 100
//12 + 02 + 02 = 1
//
//By contrast, 4 is not happy because:
//42 = 16
//12 + 62 = 37
//32 + 72 = 58
//52 + 82 = 89
//82 + 92 = 145
//12 + 42 + 52 = 42
//42 + 22 = 20
//22 + 02 = 4
//...
//
//Attempting to solve this using recursion.

using Dumpify;

namespace CodeStepByStep_CSharp.Collections.Set
{
    public class IsHappyNumber
    {
        public static void RunIsHappyNumber()
        {
            List<int> allNumbs = new();
            //int origNumb = 6;
            int origNumb = 139;
            int count = 0;
            HashSet<int> numberExists = new();

            BreakApartNumber(origNumb, allNumbs);
            bool isHappy = CheckForHappy(allNumbs, count, numberExists);

            if (isHappy)
            {
                Console.WriteLine($"{origNumb} is a happy number!");
            }
            else
            {
                Console.WriteLine($"{origNumb} is not a happy number!");
            }
        }

        private static bool CheckForHappy(List<int> allNumbs, int count, HashSet<int> numberExists)
        {
            int sum = 0;

            foreach (int n in allNumbs)
            {
                sum += (int)Math.Pow(n, 2);
            }

            if (numberExists.Contains(sum))
            {
                return false;
            }

            numberExists.Add(sum);

            if (sum == 1)
            {
                return true;
            }

            count++;
            allNumbs.Clear();

            BreakApartNumber(sum, allNumbs);

            return CheckForHappy(allNumbs, count, numberExists);
        }

        private static void BreakApartNumber(int origNumb, List<int> allNumbs)
        {
            if (origNumb == 0)
            {
                return;
            }

            allNumbs.Add(origNumb % 10);

            BreakApartNumber(origNumb / 10, allNumbs);
        }
    }
}
