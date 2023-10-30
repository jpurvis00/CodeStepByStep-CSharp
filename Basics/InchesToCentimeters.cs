using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CodeStepByStep_CSharp.Basics
{
    internal class InchesToCentimeters
    {
        //Write an interactive console program in a class named InchesToCentimeters 
        //that prompts the user to read in two input values: a number of feet, 
        //followed on a separate line by a number of inches.The program should convert 
        //this amount to centimeters, rounded to the nearest tenth.Here is a sample run 
        //of the program(user input is shown like this):

        //This program converts feet and inches to centimeters.
        //Enter number of feet: 5
        //Enter number of inches: 11
        //5ft 11in = 180.34cm

        public static void ConvertInchesToCentimeters()
        {
            var numberOfFeet = GetUserInput("Enter number of feet: ");
            var validNumberOfFeet = IsValidInt(numberOfFeet);

            var numberOfInches = GetUserInput("Enter number of inches: ");
            var validNumberOfInches = IsValidInt(numberOfInches);

            Console.WriteLine($"{validNumberOfFeet}ft {validNumberOfInches}in = {ConvertInchesToCentimeters(validNumberOfFeet, validNumberOfInches)}cm");
        }

        private static double ConvertInchesToCentimeters(int validNumberOfFeet, int validNumberOfInchest)
        {

            return ((validNumberOfFeet * 30.48) + (validNumberOfInchest * 2.54));
        }

        private static int IsValidInt(string userInput)
        {
            int validUserInteger;

            while (int.TryParse(userInput, out validUserInteger) == false)
            {
                userInput = GetUserInput("Please input a valid integer: ");
            }

            return validUserInteger;
        }

        private static string GetUserInput(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
    }
}
