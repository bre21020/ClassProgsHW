public class Customer {
    string _name;
    Address _address;
    public Customer(string Name, Address address) {
        _name = Name;
        _address = address;
    }
    public decimal GetShippingCost()
    {
        if (_address.GetCountry() == "USA") {
            return 5;
        } else {
            return 35;
        }
    }
    public string GetName() {
        return _name;
    }
    public string GetFullAddress(Address _Address) {
        return _Address.GetFullAddress();
    }
    public Address GetAddress() {
        return _address;
    }
}    
