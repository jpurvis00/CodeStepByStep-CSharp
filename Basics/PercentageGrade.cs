
namespace CodeStepByStep_CSharp.Basics
{
    internal class PercentageGrade
    {
        //What's wrong with the following code? Modify it to produce the intended output.
        //Make sure to properly utilize if/else/if statements to avoid redundancy and
        //avoid unnecessary tests. Do not use & or || in your solution.
        //What percentage did you earn? 87
        //You got a B!

        //int percent = CodeStepByStep.ReadInt("What percentage did you earn? ");
        //if (percent >= 90)
        //{
        //    Console.WriteLine("You got an A!");
        //}
        //if (percent >= 80)
        //{
        //    Console.WriteLine("You got a B!");
        //}
        //if (percent >= 70)
        //{
        //    Console.WriteLine("You got a C!");
        //}
        //if (percent >= 60)
        //{
        //    Console.WriteLine("You got a D!");
        //}
        //if (percent < 60)
        //{
        //    Console.WriteLine("You got an F!");
        //}

        public static void ShowPercentageGrade()
        {
            Console.Write("What percentage did you earn? ");
            var userInput = Console.ReadLine();
            
            int.TryParse(userInput, out var percent);

            if (percent >= 90)
            {
                Console.WriteLine("You got an A!");
            }
            else if (percent >= 80)
            {
                Console.WriteLine("You got a B!");
            }
            else if (percent >= 70)
            {
                Console.WriteLine("You got a C!");
            }
            else if (percent >= 60)
            {
                Console.WriteLine("You got a D!");
            }
            else
            {
                Console.WriteLine("You got an F!");
            }
        }
    }
}
