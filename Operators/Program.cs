using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare some variables to use with operators later.
            int x = 10, y = 5;
            string a = "abcd", b = "efgh";
            bool t = true, f = false;

            // Basic math operators.
            Console.WriteLine("---------- Basic Math ----------");
            Console.WriteLine((x / y) * x);
            Console.WriteLine(a + b);

            // Increment & Decrement operators.
            Console.WriteLine("---------- Shorthand -----------");
            Console.WriteLine("x before increment: {0}", x);
            Console.WriteLine("y before decrement: {0}", y);
            x++;
            y--;
            Console.WriteLine("x after increment: {0}", x);
            Console.WriteLine("y after decrement: {0}", y);

            // Logical operators
            Console.WriteLine(x > y && y >= 5); // && = and
            Console.WriteLine(x > y || y >= 5); // || = or
            Console.WriteLine(t && f);
            Console.WriteLine(t || f);

            // null-coalescing operators
            string str = null;
            string str2 = "hello";
            Console.WriteLine(str ?? "Unknown string"); // Returns the right operand if the left one is null.

            str ??= "it was null"; // Assigns the value to str only if str is null.
            str2 ??= "it was null";
            Console.WriteLine("str: {0}", str);
            Console.WriteLine("str2: {0}", str2);
        }
    }
}
