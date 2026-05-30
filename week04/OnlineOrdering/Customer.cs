namespace OnlineOrdering
{
    public class Customer
    {
        // Private member variables
        private string _name;
        private Address _address;

    
        public Customer(string name, Address address)
        {
            _name = name;
            _address = address;
        }

        // Name property
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        // Address property
        public Address Address
        {
            get { return _address; }
            set { _address = value; }
        }

        // Returns true if the customer lives in the USA
        public bool IsInUSA()
        {
            return _address.IsInUSA();
        }
    }
}