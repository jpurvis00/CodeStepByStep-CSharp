using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CodeStepByStep_CSharp.Basics
{
    internal class Receipt2
    {
        //The following console program always computes the same output.
        //Modify it to be an interactive program that prompts the user to
        //enter the meal cost as shown and computes the rest of the values
        //based on that meal cost.Here are two example logs of execution:

        //public static void Main()
        //{
        //    // Calculate total owed, assuming 8% tax / 15% tip
        //    int subtotal = 38 + 40 + 30;
        //    double tax = subtotal * .08;
        //    double tip = subtotal * .15;
        //    double total = subtotal + tax + tip;

        //    Console.WriteLine("Subtotal: ${0:F2}", subtotal);
        //    Console.WriteLine("Tax: ${0:F2}", tax);
        //    Console.WriteLine("Tip: ${0:F2}", tip);
        //    Console.WriteLine("Total: ${0:F2}", total);
        //}

        //What was the meal cost? 50
        //Subtotal: $50.00
        //Tax: $4.00
        //Tip: $7.50
        //Total: $61.50 

        //What was the meal cost? 125
        //Subtotal: $125.00
        //Tax: $10.00
        //Tip: $18.75
        //Total: $153.75

        private static readonly decimal _tax = .08M;
        private static readonly decimal _tip = .15M;

        public static void ComputeTotalMealCost()
        {
            var mealCost = PromptUserForInput();
            
            (var tax, var tip, var total) = CalculateMealCost(mealCost);

            DisplayOutput("Subtotal:", mealCost);
            DisplayOutput("Tax:", tax);
            DisplayOutput("Tip:", tip);
            DisplayOutput("Total:", total);
        }

        private static (decimal, decimal, decimal) CalculateMealCost(decimal mealCost)
        {

            decimal tax = mealCost * _tax;
            decimal tip = mealCost * _tip;
            decimal total = mealCost + tax + tip;
            
            return (tax, tip, total);
        }

        private static void DisplayOutput(string message, decimal amount)
        {
            Console.WriteLine($"{message} {amount.ToString("C", CultureInfo.CurrentCulture)}");
        }

        private static decimal PromptUserForInput()
        {
            bool isValidInput = false;
            decimal validDecimal = 0;

            while (isValidInput == false)
            {
                Console.Write("What was the meal cost? ");
                (isValidInput, validDecimal) = CheckForValidIntEntered(Console.ReadLine());
            }

            return validDecimal;
        }

        private static (bool, decimal) CheckForValidIntEntered(string userInput)
        {
            decimal result;
            bool isValidDecimal = decimal.TryParse(userInput, out result);

            return(isValidDecimal, result);
        }
    }
}
