public class Reception : Event {
    string _rSVPAddress;
    string GetRSVPAddress() {
        return _rSVPAddress;
    }
    public Reception(string Title, string Description, string Date, string Time, Address address, string EventType, string RSVPAddress)
        : base(Title, Description, Date, Time, address, EventType) {
            _rSVPAddress = RSVPAddress;
    }
    public string GetFullDetails() {
        string Details = GetTitle() + ":\n" + GetDescription() + "\n" + GetDate() + " - " + GetTime() + "\n" + GetAddress() + "\n" + GetEventType() + " - " + GetRSVPAddress();
        return Details;
    }
}