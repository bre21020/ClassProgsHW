public class Reception : Event {
    string _RSVPAddress;
    string GetRSVPAddress() {
        return _RSVPAddress;
    }
    public Reception(string Title, string Description, string Date, string Time, Address address, string EventType, string RSVPAddress)
        : base(Title, Description, Date, Time, address, EventType) {
            _RSVPAddress = RSVPAddress;
    }
    public string GetFullDetails() {
        string Details = GetTitle() + ":\n" + GetDescription() + "\n" + GetDate() + " - " + GetTime() + "\n" + GetAddress() + "\n" + GetEventType() + " - " + GetRSVPAddress();
        return Details;
    }
}