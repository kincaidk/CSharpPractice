using System;
using System.Text; // StringBuilder class is in here.

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            int jumpCount = 10;
            string[] animals = {"goats", "cats", "pigs"};

            int maximumStringCapacity = 200;
            StringBuilder sb = new StringBuilder("Initial string.", maximumStringCapacity);

            // Print basic stats about StringBuilder.
            Console.WriteLine($"Capacity: {sb.Capacity}; Length: {sb.Length}");

            // Use Append to add strings to the StringBuilder.
            sb.Append("The quick brown fox ");
            sb.Append("jumps over the lazy dog");

            // Use AppendLine to append a line ending
            sb.AppendLine();

            // Use AppendFormat to append formatted strings.
            sb.AppendFormat("He did this {0} times", jumpCount);
            sb.AppendLine();

            // Use AppendJoin to iterate over a sequence of values.
            sb.Append("He also jumped over ");
            sb.AppendJoin(", ", animals);

            // Use Replace to modify the text
            sb.Replace("fox", "cat");

            // Use Insert to add content at a desired index.
            sb.Insert(2, "~INSERTED TEXT~");
            
            // Print the string itself.
            Console.WriteLine(sb.ToString());
            // Print basic stats about StringBuilder again.
            Console.WriteLine($"Capacity: {sb.Capacity}; Length: {sb.Length}");

            //




        }
    }
}
