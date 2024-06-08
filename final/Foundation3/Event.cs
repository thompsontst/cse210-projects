using System;

namespace EventManagement
{  
 
  public abstract class Event
    {
        private string _TitleOfEvents ;
        private string _eventDescription;
        private DateTime _dateOfEvents;
        public TimeSpan _EventTime;
        private Address _address;

        public Event(string title, string description, DateTime date, TimeSpan time, Address address)
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
       public string DisplayShortDescription()
    {
        return $"Type: {DisplayTypeOfEvent()}\n" +
               $"Title: {_TitleOfEvents}\n" +
               $"Date: {_dateOfEvents.ToShortDateString()}";
    }
        public virtual string DisplayEventStandardDetails()
        {
            return $"{_TitleOfEvents }\n{_eventDescription}\nDate: {_dateOfEvents.ToShortDateString()}\nTime: { _EventTime.ToString(@"hh\:mm")}\nAddress: {_address.EVentAddress()}";
        }
        public virtual string DisplayAdertisementMessage()
        {
            return $"Join us for {_TitleOfEvents} on {_dateOfEvents} at {_address.EVentAddress()} by {_EventTime}!";
        }
    public  abstract string DisplayTypeOfEvent();
    public abstract string DisplaySpecificDetails();
    }
}