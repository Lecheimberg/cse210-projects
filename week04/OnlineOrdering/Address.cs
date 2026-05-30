using System;
namespace OnlineOrdering
{
    public class Address
    {
        // Private member variables
        private string _street;
        private string _city;
        private string _stateOrProvince;
        private string _country;

    
        public Address(string street, string city, string stateOrProvince, string country)
        {
            _street = street;
            _city = city;
            _stateOrProvince = stateOrProvince;
            _country = country;
        }

        // Street property
        public string Street
        {
            get { return _street; }
            set { _street = value; }
        }

        // City property
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        // State or Province property
        public string StateOrProvince
        {
            get { return _stateOrProvince; }
            set { _stateOrProvince = value; }
        }

        // Country property
        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }

        // Returns true if the address is in the USA
        public bool IsInUSA()
        {
            return _country.Trim().ToLower() == "usa";
        }

        // Returns the full address as a formatted string
        public override string ToString()
        {
            return $"{_street}\n{_city}, {_stateOrProvince}\n{_country}";
        }
    }
}