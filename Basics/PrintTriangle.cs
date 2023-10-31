
namespace CodeStepByStep_CSharp.Basics
{
    internal class PrintTriangle
    {
        //Write a method named PrintTriangle that uses for loops to produce the following output:
        //
        //#
        //##
        //###
        //####
        //#####
        //######

        public static void DisplayTriangle()
        {
            for(int i = 6; i > 0; i--)
            {
                for (int j = 0; j < ((6 - i) + 1); j++)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
            }
        }
    }
}
