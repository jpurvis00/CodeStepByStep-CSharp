//Write a method named Mean that accepts as a parameter a List 
//of real numbers, and returns the arithmetic mean (average) 
//of the integers in the list as a real number. For example, 
//if the list passed contains {2.0, 4.5, 6.5, 1.0}, your method 
//should return 3.5. If the list is empty, return 0.0. Do not 
//modify the list that is passed in.

using Dumpify;

namespace CodeStepByStep_CSharp.Collections.List
{
    public class Mean
    {
        public static void RunMean()
        {
            List<double> l1 = new() { 2.0, 4.5, 6.5, 1.0 };
            //List<double> l1 = new() { };
            double mean = 0.0;

            if (l1.Count == 0)
            {
                mean = 0.0;
            }
            else
            {
                foreach (double numb in l1)
                {
                    mean += numb;
                }
                mean /= l1.Count;
            }

            //Console.WriteLine(mean);

            mean.DumpConsole();
        }
    }
}
