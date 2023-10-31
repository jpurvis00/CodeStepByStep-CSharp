using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CodeStepByStep_CSharp.Basics
{
    internal class PrintProgram
    {
        //Write a complete C# program in a class named PrintProgram whose output is
        //the text that would be the source code of a C# program named Hello that prints "Hello, world!" as its output:
        //
        //public class Hello
        //{
        //    public static void Main()
        //    {
        //        Console.WriteLine("Hello, world!");
        //    }
        //}
        //Your program must produce exactly the output shown in order to
        //pass(using exactly four spaces for each increment of indentation in the output).

        public static void DisplayPrintProgram()
        {
            Console.WriteLine("public class Hello");
            Console.WriteLine("{");
            Console.WriteLine("    public static void Main()");
            Console.WriteLine("    {");
            Console.WriteLine("        Console.WriteLine(\"Hello, world!\")");
            Console.WriteLine("    }");
            Console.WriteLine("}");

            Console.WriteLine("\nAnother way to output the text:");
            Console.WriteLine("public class Hello" +
                "\n{" +
                "\n   public static void Main()" +
                "\n   {" +
                "\n       Console.WriteLine(\"Hello, world!\"" +
                "\n   }" +
                "\n}");
        }
    }
}
