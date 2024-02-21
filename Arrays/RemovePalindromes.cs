
//Write a method named RemovePalindromes that that removes all strings
//that are palindromes from an array of strings.

//Your method accepts an array of strings as a parameter and modifies
//its contents, replacing every string in the array that is a palindrome
//with an empty string, "". For example, if an array named a stores the
//following element values:

//string[] a = {"Madam", "raceCAR", "", "hi", "A", "Abba", "banana", "dog God",
//              "STOP otto POTS", "Madame", "C#", "LevEL", "staTS"};
//Then the call of RemovePalindromes(a); should change it to contain the
//following element values. Notice that the palindromes from the array such
//as "Madam" and "LevEL" have been replaced by "".

//             {"", "", "", "hi", "", "banana", "", "", "Madame", "C#", "", ""}
//Constraints: You are to modify the existing array in-place. Do not create any
//other data structures such as temporary arrays. You may create as many strings
//as you like, and you may use as many simple variables (such as ints) as you like.

//Note: You may want to go solve the string problem isPalindrome first and
//use it as part of your solution to this problem.

using System.Net.NetworkInformation;

namespace CodeStepByStep_CSharp.Arrays
{
    public class RemovePalindromes
    {
        public static void RunRemovePalindromes(string[] a)
        {
            DisplayArray(a);

            for(int i = 0; i < a.Length; i++)
            {
                if (IsPalindrome(a[i]) == true)
                {
                    a[i] = string.Empty;
                }
            }

            Console.WriteLine("\n");
            DisplayArray(a);
        }

        private static void DisplayArray(string[] a)
        {
            for(int i = 0;i < a.Length;i++)
            {
                Console.Write($"{a[i]}, ");
            }
        }

        public static bool IsPalindrome(string palindrome)
        {
            bool isPalindrome = false;

            if(palindrome.Length == 1 )
            {
                return true;
            }

            palindrome = palindrome.ToLower();

            for(int i = 0; i < palindrome.Length / 2; i++)
            {
                if (palindrome[i].Equals(palindrome[palindrome.Length - i - 1]))
                {
                    isPalindrome = true;
                }
                else
                {
                    return false;
                }
            }    

            return isPalindrome;
        }
    }
}
