public class Outdoor : Event {
    string _weatherForecast;
    string GetWeatherForecast() {
        return _weatherForecast;
    }
    public Outdoor(string Title, string Description, string Date, string Time, Address address, string EventType, string WeatherForecast)
        : base(Title, Description, Date, Time, address, EventType) {
            _weatherForecast = WeatherForecast;
    }
    public string GetFullDetails() {
        string Details = GetTitle() + ":\n" + GetDescription() + "\n" + GetDate() + " - " + GetTime() + "\n" + GetAddress() + "\n" + GetEventType() + " - " + GetWeatherForecast();
        return Details;
    }
}