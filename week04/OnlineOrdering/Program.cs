using System;
using System.Collections.Generic;

namespace OnlineOrdering
{
    class Program
    {
        static void Main(string[] args)
        {
            // First order: customer in the USA
            Address address1 = new Address("123 Main St", "Rexburg", "ID", "USA");
            Customer customer1 = new Customer("John Smith", address1);

            List<Product> products1 = new List<Product>
            {
                new Product("Keyboard", 1001, 29.99m, 2),
                new Product("Mouse", 1002, 14.50m, 1),
                new Product("Monitor", 1003, 199.99m, 1)
            };

            Order order1 = new Order(customer1, products1);

            // Second order: customer outside the USA
            Address address2 = new Address("45 Queen St", "Toronto", "ON", "Canada");
            Customer customer2 = new Customer("Emily Johnson", address2);

            List<Product> products2 = new List<Product>
            {
                new Product("Notebook", 2001, 3.25m, 10),
                new Product("Pen Pack", 2002, 5.00m, 3)
            };

            Order order2 = new Order(customer2, products2);

            // Display order 1 information
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order1.GetTotalCost():0.00}");
            Console.WriteLine();

            // Display order 2 information
            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order2.GetTotalCost():0.00}");
        }
    }
}