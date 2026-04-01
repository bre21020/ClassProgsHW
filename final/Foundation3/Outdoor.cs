public class Outdoor : Event {
    string _WeatherForecast;
    string GetWeatherForecast() {
        return _WeatherForecast;
    }
    public Outdoor(string Title, string Description, string Date, string Time, Address address, string EventType, string WeatherForecast)
        : base(Title, Description, Date, Time, address, EventType) {
            _WeatherForecast = WeatherForecast;
    }
    public string GetFullDetails() {
        string Details = GetTitle() + ":\n" + GetDescription() + "\n" + GetDate() + " - " + GetTime() + "\n" + GetAddress() + "\n" + GetEventType() + " - " + GetWeatherForecast();
        return Details;
    }
}