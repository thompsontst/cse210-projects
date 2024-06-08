using System;

namespace EventManagement
{ 

public class Lecture : Event
    {
        private string _Speaker;
        private int _Capacity;

        public Lecture(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity)
            : base(title, description, date, time, address)
        {
            _Speaker = speaker;
            _Capacity = capacity;
        }
    public  override string DisplayTypeOfEvent()
 {
    return "Lecture";
 }
        public override string DisplaySpecificDetails()
        {
            return $"Type: {DisplayTypeOfEvent()}\nSpeaker: {_Speaker} \n Capacity: {_Capacity}";
        }
        
    }
}