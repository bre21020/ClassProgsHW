public class Address {
    private string _City;
    private string _State;
    private string _Country;
    public Address(string City, string State, string Country) {
        _City = City;
        _State = State;
        _Country = Country;
    }
    public bool USADeterminer()
    {
        if (_Country == "USA") {
            return true;
        }
        else {
            return false;
        }
    }
    public string GetFullAddress() {
        string FullAddress = _City + ", " + _State + " " + _Country;
        return FullAddress;
    }
    public string GetCountry() {
        return _Country;
    }
}    
