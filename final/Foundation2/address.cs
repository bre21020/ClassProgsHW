public class Address {
    private string _city;
    private string _state;
    private string _country;
    public Address(string City, string State, string Country) {
        _city = City;
        _state = State;
        _country = Country;
    }
    public bool USADeterminer()
    {
        if (_country == "USA") {
            return true;
        }
        else {
            return false;
        }
    }
    public string GetFullAddress() {
        string FullAddress = _city + ", " + _state + " " + _country;
        return FullAddress;
    }
    public string GetCountry() {
        return _country;
    }
}    
