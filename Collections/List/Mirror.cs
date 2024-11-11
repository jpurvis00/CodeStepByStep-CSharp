//Write a method named Mirror that accepts a List of 
//strings as a parameter and produces a mirrored copy 
//of the list as output, with the original values followed 
//by those same values in the opposite order. For example, 
//if a List variable named list contains the values {"a", "b", "c"}, 
//after a call of Mirror(list); it should contain {"a", "b", "c", "c", "b", "a"}.

using Dumpify;

namespace CodeStepByStep_CSharp.Collections.List
{
    public class Mirror
    {
        public static void RunMirror()
        {
            List<string> list = new() { "a", "b", "c" };

            for (int i = list.Count - 1; i >= 0; i--)
            {
                list.Add(list[i]);
            }

            list.DumpConsole();
        }
    }
}
