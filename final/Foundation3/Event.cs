using System;

namespace EventManagement
{  
 
  public class Event
    {
        private string _TitleOfEvents ;
        private string _eventDescription;
        private DateTime _dateOfEvents;
        public string _EventTime;
        private Address _address;

        public Event(string title, string description, DateTime date, string time, Address address)
        {
            _TitleOfEvents = title;
            _dateOfEvents = date;
            _address = address;
            _eventDescription = description;
             _EventTime = time;
        }

        public string GetName()
        {
            return _TitleOfEvents;
        }

        public DateTime GetDate()
        {
            return _dateOfEvents;
        }

        public string GetAddress()
        {
            return _address.ToString();
        }
        public virtual string DisplayEventInfoDetails()
        {
            return $"{_TitleOfEvents }\n{_eventDescription}\nDate: {_dateOfEvents.ToShortDateString()}\nTime: {_EventTime}\nAddress: {_address}";
        }
        public virtual string DisplayAdertisementMessage()
        {
            return $"Join us for {_TitleOfEvents} on {_dateOfEvents} at {_address}!";
        }
    }
}