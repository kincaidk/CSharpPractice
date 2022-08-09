using System;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                :: public ::
                The thing can be accessed by any other code in your program.

                :: protected ::
                The thing can be accessed ONLY by code within the class OR a subclass.

                :: private ::
                The thing can be accessed ONLY be code within the class.
            */

            Book lotr = new Book("The Lord of the Rings", 1000);
            
            // Access some properties.
            Console.WriteLine(lotr.Name);
            Console.WriteLine(lotr.PageCount);

            // Set the Price
            lotr.Price = 300.33m;
            Console.WriteLine(lotr.Price);

            // Change the page count
            lotr.PageCount = 1001;
            Console.WriteLine(lotr.PageCount);


        }
    }
}
