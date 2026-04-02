public class Event {
    string _title;
    string _description;
    string _date;
    string _time;
    Address _address;
    string _eventType;
    public string GetTitle() {
        return _title;
    }
    public string GetDescription() {
        return _description;
    }
    public string GetDate() {
        return _date;
    }
    public string GetTime() {
        return _time;
    }
    public string GetAddress() {
        return _address.GetFullAddress();
    }
    public string GetEventType() {
        return _eventType;
    }
    public string GetStandardDetails() {
        string Details = GetTitle() + ":\n" + GetDescription() + "\n" + GetDate() + " - " + GetTime() + "\n" + GetAddress();
        return Details;
    }
    public string GetShortDescription() {
        string Details = GetEventType() + " - " + GetTitle() + "\n" + GetDate();
        return Details;
    }
    public Event(string Title, string Description, string Date, string Time, Address address, string EventType) {
        _title = Title;
        _description = Description;
        _date = Date;
        _time = Time;
        _address = address; //gotta love capitilization in c sharp thanks microsoft thank you so much for ruining my life #javascriptForever
        _eventType = EventType; // I also love how every function has to start with a capital letter meanwhile foreach() is out here living its best lowercase life. good for you, foreach, keep the rebellion alive
    }
}