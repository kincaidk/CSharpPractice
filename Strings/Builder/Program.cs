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

            
        }
    }
}
