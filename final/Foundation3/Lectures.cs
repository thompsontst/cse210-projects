using System;

namespace EventManagement
{ 

public class Lecture : Event
    {
        private string _Speaker;
        private int _Capacity;

        public Lecture(string title, string description, DateTime date, string time, Address address, string speaker, int capacity)
            : base(title, description, date, time, address)
        {
            _Speaker = speaker;
            _Capacity = capacity;
        }

        public override string DisplayEventInfoDetails()
        {
            return $"{DisplayAdertisementMessage()}\nType: Lecture\nSpeaker: {_Speaker}\nCapacity: {_Capacity}";
        }
    }
}