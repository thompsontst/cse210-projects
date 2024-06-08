using System;

namespace EventManagement
{
public class OutdoorGathering : Event
    {
        private string WeatherForecast;

        public OutdoorGathering(string title, string description, DateTime date, string time, Address address, string weatherForecast)
            : base(title, description, date, time, address)
        {
            WeatherForecast = weatherForecast;
        }


public override string DisplayEventInfoDetails()
        {
            return $"{DisplayAdertisementMessage()}\nType: Outdoor Gathering\nWeather: {WeatherForecast}";
        }
    }
}
