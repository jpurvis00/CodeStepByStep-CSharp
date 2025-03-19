/* Write a method named AskFileName that repeatedly prompts 
 * the user for a file name until the user types the name of 
 * a file that exists on the system. Once you get a good file name, 
 * return that file name as a string. Here is a sample dialogue 
 * from one call to your method, assuming that the file good.txt 
 * does exist and the others do not: 
 *
 * Type a file name: bad.txt
 * Type a file name: not_here.txt
 * Type a file name: good.txt
 */

namespace CodeStepByStep_CSharp.FileInputOutput
{
    public class AskFileName
    {
        public static void RunAskFileName()
        {
            string? fileName = GetFileName();
            Console.WriteLine($"You got it! {fileName}");
        }

        private static string GetFileName()
        {
            bool status = false;
            //string goodFileName = "good.txt";
            string goodFileName = "GOOD.TXT";
            string? fileName = String.Empty;

            while (!status)
            {
                Console.Write("Type a file name: ");
                fileName = Console.ReadLine();

                if (goodFileName.Equals(fileName, StringComparison.InvariantCultureIgnoreCase))
                {
                    status = true;
                }
            }

            return fileName.ToLower();
        }
    }
}
