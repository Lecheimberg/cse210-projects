namespace OnlineOrdering
{
    public class Product
    {
        // Private member variables
        private string _name;
        private int _productId;
        private decimal _price;
        private int _quantity;

    
        public Product(string name, int productId, decimal price, int quantity)
        {
            _name = name;
            _productId = productId;
            _price = price;
            _quantity = quantity;
        }

        // Name property
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        // Product ID property
        public int ProductId
        {
            get { return _productId; }
            set { _productId = value; }
        }

        // Price property
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }

        // Quantity property
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        // Calculates the total cost for this product
        public decimal GetTotalCost()
        {
            return _price * _quantity;
        }
    }
}