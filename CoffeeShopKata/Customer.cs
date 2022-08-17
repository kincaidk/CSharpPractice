using System;

namespace CoffeeShopKata
{
    class Customer
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
        
        // Class variables
        private static int customerCount = 0;

        // Fields
        private int customerID;
        private string customerName;
        private int stampCount = 0;
        private int freeCoffeeCredits = 0;
        private int freeCoffeesObtained = 0;

        // Constants
        private const int FREE_COFFEE_THRESHOLD = 6;

        // Constructor
        public Customer(string firstName, string lastName) {
            customerName = $"{firstName} {lastName}";
            customerID = customerCount;
            customerCount++;
        }

        // Properties
        public int CustomerID {
            get => customerID;
        }
        public string CustomerName {
            get => customerName;
        }
        public int StampCount {
            get => stampCount;
        }
        public int FreeCoffeeCredits {
            get => freeCoffeeCredits;
        }
        public int FreeCoffeesObtained {
            get => freeCoffeesObtained;
        }

        // Methods
        /*
            Increments stampCount. 
            If necessary, increments freeCoffeeCredits.
        */
        public void PurchaseCoffee() {
            stampCount++;
            if (stampCount % FREE_COFFEE_THRESHOLD == 0) {
                freeCoffeeCredits++;
            }
        }
        /*
            Returns true if the customer is eligible for a free coffee. False otherwise.
            Decrements freeCoffeeCredits, if necessary.
            Increments freeCoffeesObtained, if necessary.
        */
        public bool RedeemFreeCoffee() {
            if (freeCoffeeCredits > 0) {
                freeCoffeeCredits--;
                freeCoffeesObtained++;
                return true;
            } else {
                return false;
            }
        }
        /*
            Prints the stamp count and free coffee credits of this customer.
        */
        public void ListStampCountAndFreeCoffeeCredits() {
            Console.WriteLine($"{CustomerName} has {stampCount} stamps and is eligible for {freeCoffeeCredits} free coffees!");
        }
    }
}