using System;

namespace Formatting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sales = {100000, 150000, 200000, 223000};
            double[] doubles = {0.386, 0.413, 0.421, 0.457};
            string str1 = "string";
            int intVal = 1234;
            decimal decimalVal = 1234.5678m;

            // BASIC FORMATTING
            Console.WriteLine("{0}", str1);

            // NUMERICAL FORMATTING
            // N (number), G (general), F (fixed-point), E (exponential), D (decimal), P (percent), X (Hexadecimal), C (Currency in local format)
            Console.WriteLine("{0:D}, {0:N}, {0:F}, {0:G}", intVal);
            Console.WriteLine("{0:E}, {0:N}, {0:F}, {0:G}", decimalVal);

            // Add a number after the format to specify precision.
            Console.WriteLine("{0:D6}, {0:N2}, {0:F1}, {0:G3}", intVal);

            // Formatting with alignment and spacing. The number after the comma is the amount of leading spaces to use.
            Console.WriteLine("{0,12:P0} {1,12:P0} {2,12:P1} {3,12:P2}", doubles[0], doubles[1], doubles[2], doubles[3]);
            Console.WriteLine("{0,12:C0} {1,12:C0} {2,12:C0} {3,12:C0}", sales[0], sales[1], sales[2], sales[3]);

            // String interpolation
            Console.WriteLine($"Preface the quotation marks with a dollar sign to use {str1} interpolation!");

        }
    }
}
