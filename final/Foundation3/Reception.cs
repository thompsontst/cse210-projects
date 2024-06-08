using System;

namespace EventManagement
{

public class Reception : Event
    {
        private string _rsvpEmail;
        

        public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail)
            : base(title, description, date, time, address)
        {
            _rsvpEmail = rsvpEmail;
        }

 public  override string DisplayTypeOfEvent()
 {
    return "Reception";
 }
        public override string DisplaySpecificDetails()
        {
            return $"Type: {DisplayTypeOfEvent()}\nRSVP Email: {_rsvpEmail}";
        }
    }
}