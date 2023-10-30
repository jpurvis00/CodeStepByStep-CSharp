
namespace CodeStepByStep_CSharp.Basics
{
    internal class EvenAverage
    {
        //Write C# code that prompts the user for nonzero integers, and then prints the average of all 
        //even numbers typed. (When the user types 0, stop asking for input.) You may assume that the 
        //user types at least one even integer. The following is an example output from one run of your code:

        //int? 1
        //int? 3
        //int? 2
        //int? 6
        //int? 4
        //int? 10
        //int? 9
        //int? 0
        //Average: 5.5

        public static void FindEvenNumberAverage()
        {
            int userInput = 0;
            double sum = 0;
            double divideBy = 0;

            Console.WriteLine("Input nonzero integers.  When finished, type 0.");

            do
            {
                Console.Write("int? ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out userInput) == false)
                {
                    Console.WriteLine("Please input a valid integer!");

                    //Default behavior of TryParse is that if it fails, it sets the out var to 0.
                    //We don't want 0 bc it will exit our loop prematurely.
                    userInput = -1;
                }

                if (userInput % 2 == 0 && userInput != 0)
                {
                    sum += userInput;
                    divideBy++;
                }

            } while(userInput != 0);

            try
            {
                if(divideBy == 0)
                {
                    throw new ArgumentException("You can not divide by zero.  Please make sure you input at least one non zero integer.");
                }

                var average = sum / divideBy;
                Console.WriteLine($"The average of the even integers is: {average}.");
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
