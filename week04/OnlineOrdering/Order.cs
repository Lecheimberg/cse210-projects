using System.Collections.Generic;
using System.Text;

namespace OnlineOrdering
{
    public class Order
    {
        // Private member variables
        private List<Product> _products;
        private Customer _customer;

    
        public Order(Customer customer, List<Product> products)
        {
            _customer = customer;
            _products = products;
        }

        // Products property
        public List<Product> Products
        {
            get { return _products; }
            set { _products = value; }
        }

        // Customer property
        public Customer Customer
        {
            get { return _customer; }
            set { _customer = value; }
        }

        // Calculates the total order cost including shipping
        public decimal GetTotalCost()
        {
            decimal total = 0;

            // Add the total cost of each product
            foreach (Product product in _products)
            {
                total += product.GetTotalCost();
            }

            // Add shipping based on customer location
            if (_customer.IsInUSA())
            {
                total += 5;
            }
            else
            {
                total += 35;
            }

            return total;
        }

        // Creates the packing label
        public string GetPackingLabel()
        {
            StringBuilder label = new StringBuilder();
            label.AppendLine("Packing Label:");

            foreach (Product product in _products)
            {
                label.AppendLine($"{product.Name} (Product ID: {product.ProductId})");
            }

            return label.ToString();
        }

        // Creates the shipping label
        public string GetShippingLabel()
        {
            StringBuilder label = new StringBuilder();
            label.AppendLine("Shipping Label:");
            label.AppendLine(_customer.Name);
            label.AppendLine(_customer.Address.ToString());

            return label.ToString();
        }
    }
}