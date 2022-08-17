using System;

namespace CoffeeShopKata
{
    class Program
    {
        /*
            Design a loyalty program for a coffee shop.
            
            Customers collect 1 stamp per coffee.
            When they reach 6 stamps, they earn 1 free coffee.

            The application supports the following operations:
                -Create a customer.
                -Create a stamp for a customer.
                -List all stamps and free coffees for a customer.
                -Redeem a free coffee.
        */

        static void Main(string[] args)
        {
            // Create customers.
            Customer ley = new Customer("Ley", "A");
            Customer kellen = new Customer("Kellen", "Kincaid");

            Console.WriteLine($"{ley.CustomerName}'s ID: {ley.CustomerID}");
            Console.WriteLine($"{kellen.CustomerName}'s ID: {kellen.CustomerID}");

            // Have a customer purchase coffee without earning a free coffee.
            ley.PurchaseCoffee();
            ley.PurchaseCoffee();
            ley.PurchaseCoffee();
            ley.PurchaseCoffee();
            ley.PurchaseCoffee();

            Console.WriteLine($"{ley.CustomerName}'s free coffees obtained: {ley.FreeCoffeesObtained}");
            Console.WriteLine($"{kellen.CustomerName}'s free coffees obtained: {kellen.FreeCoffeesObtained}");

            // Have a customer earn a free coffee.
            ley.ListStampCountAndFreeCoffeeCredits(); // 5 stamps, 0 freeCoffeeCredits
            ley.PurchaseCoffee();
            ley.ListStampCountAndFreeCoffeeCredits(); // 6 stamps, 1 freeCoffeeCredits
            
            // Have a customer redeem a free coffee.
            ley.RedeemFreeCoffee();
            ley.ListStampCountAndFreeCoffeeCredits(); // 6 stamps, 0 freeCoffeeCredits

            Console.WriteLine($"{ley.CustomerName}'s free coffees obtained: {ley.FreeCoffeesObtained}");
            Console.WriteLine($"{kellen.CustomerName}'s free coffees obtained: {kellen.FreeCoffeesObtained}");
        }
    }
}
