using System;

namespace VarsAndData
{
    class Program
    {
        static void Main(string[] args)
        {
            // Basic data types.
            int i = 4;
            float f = 2.0f;
            decimal d = 10.0m;
            bool b = true;
            char c = 'c';

            // Collection of chars
            string str = "a string";

            // Complier figures out what the data type is.
            var x = 10;
            var z = "Hello";

            // Different ways to create an array.
            int[] intArray = new int[5]; // integer array of length 5, with nothing in it.
            string[] stringArray = {"apple", "lemon", "orange"}; // string array with 3 defined elements.

            // Print values using a formatted string.
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}", i, f, d, b, c, str, x, z, intArray, stringArray);

            // null represents the absence of a value.
            object obj = null;
            Console.WriteLine(obj); // Nothing will be printed.

            // Implicit conversion between types.
            long bignum;
            bignum = i; // recall that i was defined earlier as an int.

            // Explicit conversions (casts)
            float i_to_f = (float)i;
            Console.WriteLine(i_to_f);
            int f_to_i = (int)f;
            Console.WriteLine(f_to_i);
        }
    }
}
