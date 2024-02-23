//Write a method named SwitchPairs that accepts an array of strings as a
//parameter and switches the order of pairs of values in the array. Your
//method should swap the order of the first two values, then switch the
//order of the next two, and so on. For example, if the array stores:

//string[] a = { "a", "bb", "c", "ddd", "ee", "f", "g" };
//SwitchPairs(a);
//Your method should switch the first pair ("a", "bb"), the second
//pair ("c", "ddd") and the third pair ("ee", "f"), to yield this array:

//{ "bb", "a", "ddd", "c", "f", "ee", "g"}
//If there are an odd number of values, the last element is not moved.

//You may assume that the array is not null and that no element of the array is null.


namespace CodeStepByStep_CSharp.Arrays
{
    public class SwitchPairs
    {
        public static void RunSwitchPairs(string[] list)
        {
            Console.Write("Original array: ");

            for(int i=0; i < list.Length;i++)
            {
                Console.Write($"{list[i]} ");
            }

            int goThroughLoopTimes = list.Length / 2;

            for(int i = 0; i < list.Length; i++)
            {
                if (goThroughLoopTimes > 0)
                {
                    string temp;
                    temp = list[i];
                    list[i] = list[i+1];
                    list[i+1] = temp;

                    i++;
                    goThroughLoopTimes--;
                }
            }

            DisplayNewArray(list);
        }

        private static void DisplayNewArray(string[] list)
        {

            Console.Write("\nNew array: ");

            for(int i=0; i < list.Length;i++)
            {
                Console.Write($"{list[i]} ");
            }
        }
    }
}
