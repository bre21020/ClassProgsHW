public class Lecture : Event {
    string _speakerName;
    int _capacity;
    public string GetSpeakerName() {
        return _speakerName;
    }
    public int GetCapacity() {
        return _capacity;
    }
    public Lecture(string Title, string Description, string Date, string Time, Address address, string EventType, string SpeakerName, int Capacity) 
        : base(Title, Description, Date, Time, address, EventType) {
            _speakerName = SpeakerName;
            _capacity = Capacity;
    }
    public string GetFullDetails() {
        string Details = GetTitle() + ":\n" + GetDescription() + "\n" + GetDate() + " - " + GetTime() + "\n" + GetAddress() + "\n" + GetEventType() + " - " + GetSpeakerName() + "\nCapacity: " + GetCapacity();
        return Details;
    }
}

// Example from AI explaining how to put together the constructor for child classes (using the product class from the last assignment as a base)
//public Perishable(string name, string productId, decimal pricePerUnit, decimal quantity, string expirationDate)
//        : base(name, productId, pricePerUnit, quantity) // sends shared vars to parent
//    {
//        _expirationDate = expirationDate; // handles its own unique variable
//    }


// Standard details - Lists the title, description, date, time, and address.
// Full details - Lists all of the above, plus type of event and information specific to that event type. For lectures, this includes the speaker name and capacity. For receptions this includes an email for RSVP. For outdoor gatherings, this includes a statement of the weather.
// Short description - Lists the type of event, title, and the date.
