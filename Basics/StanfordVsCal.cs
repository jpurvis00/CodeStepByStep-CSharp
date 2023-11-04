using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CodeStepByStep_CSharp.Basics
{
    internal class StanfordVsCal
    {
        //Write a complete C# program named StanfordVsCal with a main method that
        //computes who won the Stanford-Berkeley football game. The program should
        //ask the user for the two scores. You may assume that the user enters valid
        //non-negative integers. Below is an example dialogue (user input is shown like this):

        //Stanford: How many points did they score? 87
        //Cal: How many points did they score? 3
        //Stanford won!


        public static void StanforVsCal()
        {
            int stanfordScore = GetUserInput("Stanford: How many points did they score? ");
            int calScore = GetUserInput("Cal: How many points did they score? ");

            string winnerName = DetermineWinner(stanfordScore, calScore);

            DisplayWinner(winnerName);
        }

        private static void DisplayWinner(string winnerName)
        {
            if (!winnerName.Equals("Tie"))
            {
                Console.WriteLine($"{winnerName} won!");
            }
            else
            {
                Console.WriteLine($"The game was a {winnerName.ToLower()}.");
            }
        }

        private static string DetermineWinner(int stanfordScore, int calScore)
        {
            if (stanfordScore > calScore)
            {
                return "Stanford";
            }
            else if(stanfordScore < calScore)
            {
                return "Cal";
            }
            else
            {
                return "Tie";
            }
        }

        private static int GetUserInput(string messagePrompt)
        {
            bool isValidInt = false;
            int validScore = 0;

            while (isValidInt == false)
            {
                Console.Write(messagePrompt);
                (isValidInt, validScore) = CheckUserInputForValidInt(Console.ReadLine());
            }

            return validScore;
        }

        private static (bool, int) CheckUserInputForValidInt(string userInputString)
        {
            var isValidInt = int.TryParse(userInputString, out int validInt);

            return (isValidInt, validInt);
        }
    }
}
