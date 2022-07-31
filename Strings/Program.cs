using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "This is a string";
            string[] strArray = {"Apple", "Lemon", "Orange"};

            Console.WriteLine(str1);
            Console.WriteLine(str1.Length);
            Console.WriteLine(str1[5]);
            Console.WriteLine(String.Concat(strArray));
            Console.WriteLine(String.Join(", ", strArray));

            // COMPARISONS
            /*
                Returns a negative number if the first string would be sorted before the second string.
                Returns a positive number if the first string would be sorted after the second string.
                Returns 0 if the first string would be sorted the same as the second string.
            */
            Console.WriteLine(String.Compare(str1, "This is a literal string"));

            Console.WriteLine(String.Equals(str1, str1));
            Console.WriteLine(String.Equals(str1, "different string"));

            // INDEXING
            Console.WriteLine(str1.IndexOf("is")); // returns index of first occurence of the input in str.
            Console.WriteLine(str1.LastIndexOf("is")); // returns the index of the LAST occurence of the input in str.
            Console.WriteLine(str1.IndexOf("ball")); // returns -1 if the input does not exist in str.

            Console.WriteLine(str1.IndexOf(""));
            Console.WriteLine(str1.LastIndexOf(""));
        }
    }
}
