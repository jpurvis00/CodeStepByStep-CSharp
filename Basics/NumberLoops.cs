
namespace CodeStepByStep_CSharp.Basics
{
    public static class NumberLoops
    {
        /* 
         * Write nested for loops to produce the following output:
         *
         * ....1
         * ...2.
         * ..3..
         * .4...
         * 5....
         */

        public static void DisplayLoopOutput()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 5; j > 0; j--)
                {
                    if (j == (i + 1))
                    {
                        Console.Write(i + 1);
                    }
                    else
                    {
                        Console.Write(".");
                    }

                }

                Console.WriteLine();
            }
        }
    }
}
