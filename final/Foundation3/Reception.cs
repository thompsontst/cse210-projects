using System;

namespace EventManagement
{

public class Reception : Event
    {
        private string RsvpEmail;
        

        public Reception(string title, string description, DateTime date, string time, Address address, string rsvpEmail)
            : base(title, description, date, time, address)
        {
            RsvpEmail = rsvpEmail;
        }

        public override string DisplayEventInfoDetails()
        {
            return $"{DisplayAdertisementMessage()}\nType: Reception\nRSVP Email: {RsvpEmail}";
        }
    }
}