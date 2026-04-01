public class Event {
    string _Title;
    string _Description;
    string _Date;
    string _Time;
    Address _Address;
    string _EventType;
    public string GetTitle() {
        return _Title;
    }
    public string GetDescription() {
        return _Description;
    }
    public string GetDate() {
        return _Date;
    }
    public string GetTime() {
        return _Time;
    }
    public string GetAddress() {
        return _Address.GetFullAddress();
    }
    public string GetEventType() {
        return _EventType;
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
        _Title = Title;
        _Description = Description;
        _Date = Date;
        _Time = Time;
        _Address = address; //gotta love capitilization in c sharp thanks microsoft thank you so much for ruining my life #javascriptForever
        _EventType = EventType; // I also love how every function has to start with a capital letter meanwhile foreach() is out here living its best lowercase life. good for you, foreach, keep the rebellion alive
    }
}