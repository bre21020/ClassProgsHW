public class Address {
    private string _City;
    private string _State;
    private string _Country;
    public Address(string City, string State, string Country) {
        _City = City;
        _State = State;
        _Country = Country;
    }
    public string GetFullAddress() {
        string FullAddress = _City + ", " + _State + " " + _Country;
        return FullAddress;
    }
}    
