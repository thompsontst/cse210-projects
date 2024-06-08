using System;

namespace EventManagement
{
public class OutdoorGathering : Event
    {
        private string _weatherForecast;

        public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weatherForecast)
            : base(title, description, date, time, address)
        {
            _weatherForecast = weatherForecast;
        }

public  override string DisplayTypeOfEvent()
 {
    return "Outdoor Gathering";
 }
        public override string DisplaySpecificDetails()
        {
            return $"Type: {DisplayTypeOfEvent()}\nWeather Forecast: {_weatherForecast}";
        }
    }
}
