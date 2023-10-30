using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CodeStepByStep_CSharp.Basics
{
    internal class EvenSumMax
    {
        //Write a method named EvenSum that prompts the user for many integers and print the total 
        //even sum and maximum of the even numbers.You may assume that the user types at least one 
        //non-negative even integer.  
            
        //how many integers? 4
        //next integer? 2
        //next integer? 9
        //next integer? 18
        //next integer? 4
        //even sum = 24
        //even max = 18

        /* I'm making this way harder than the instructions call for.  I'm just practicing validating
         * user input and trying to make each function only do 1 thing.
         */

        public static void EvenSum()
        {
            var numOfInts = getHowManyIntegers();
            List<int> evenNumbers =  getIntegers(numOfInts);
            var evenSum = getEvenSum(evenNumbers);
            var maxEvenNumber = getMaxNumber(evenNumbers);
            showOutput(evenSum, maxEvenNumber);

        }

        private static void showOutput(int evenSum, int maxEvenNumber)
        {
            Console.WriteLine($"even sum: {evenSum}, even max: {maxEvenNumber}");
        }

        private static int getMaxNumber(List<int> evenNumbers)
        {
            return evenNumbers.Max();
        }

        private static int getEvenSum(List<int> evenNumbers)
        {
            return evenNumbers.Sum();
        }

        private static List<int> getIntegers(int numOfInts)
        {
            List<int> evenUserInts = new List<int>();

            do
            {
                //Console.Write("next integer? ");
                //var userInt = Console.ReadLine();
                var userInt = getUserInput("next integer? ");

                if (isValidInt(userInt))
                {
                    int.TryParse(userInt, out int validUserInt);

                    if (validUserInt % 2 == 0)
                    {
                        evenUserInts.Add(validUserInt);
                    }

                    numOfInts--;
                }

            } while( numOfInts > 0 );

            return evenUserInts;
        }

        private static int getHowManyIntegers()
        {
            do
            {
                var numIntegers = getUserInput("How many integers? ");

                if (isValidInt(numIntegers) == false)
                {
                    Console.Write("Please enter a valid integer. ");
                }
                else
                {
                    int.TryParse(numIntegers, out int userInput);
                    return userInput;
                }
            } while (true);
        }

        private static string getUserInput(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        private static bool isValidInt( string userInput)
        {
            if (int.TryParse(userInput, out int validInt) == true)
            {
                /* userInput is negative */
                if (validInt < 0)
                {
                    return false;
                }
                else
                {
                    return true; 
                }
            }
            else
            {
                /* userInput is not a # */
                return false;
            }
        }
    }
}
