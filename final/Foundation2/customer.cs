public class Customer {
    string _Name;
    Address _Address;
    public Customer(string Name, Address address) {
        _Name = Name;
        _Address = address;
    }
    public decimal GetShippingCost()
    {
        if (_Address.GetCountry() == "USA") {
            return 5;
        } else {
            return 35;
        }
    }
    public string GetName() {
        return _Name;
    }
    public string GetFullAddress(Address _Address) {
        return _Address.GetFullAddress();
    }
    public Address GetAddress() {
        return _Address;
    }
}    
