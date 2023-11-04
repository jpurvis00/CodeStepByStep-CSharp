using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeStepByStep_CSharp.Basics
{
    internal class Receipt
    {
        //The following console program is redundant. Rewrite it to use
        //variables and expressions so that calculations are not repeated.
        //public class Receipt
        //public static void Main()
        //    {
        //        // Compute total owed, assuming 8% tax and 15% tip
        //        Console.WriteLine("Subtotal: " + (38 + 40 + 30));
        //        Console.WriteLine("Tax: " + (38 + 40 + 30) * .08);
        //        Console.WriteLine("Tip: " + (38 + 40 + 30) * .15);
        //        Console.WriteLine("Total: " + (38 + 40 + 30 + (38 + 40 + 30) * .08 + (38 + 40 + 30) * .15));
        //    }

        private static readonly decimal _tax = .08M;
        private static readonly decimal _tip = .15M;

        public static void CalculateTotalReceipt()
        {
            decimal subtotal = 38M + 40M + 30M;
            var tax = subtotal * _tax;
            var tip = subtotal * _tip;
            var total = subtotal + tax + tip;

            DisplayOutput("Subtotal:", subtotal);
            DisplayOutput("Tax:", tax);
            DisplayOutput("Tip:", tip);
            DisplayOutput("Total:", total);
        }

        private static void DisplayOutput(string message, decimal amount)
        {
            Console.WriteLine($"{message} {amount.ToString("C", CultureInfo.CurrentCulture)}");
        }
    }
}
