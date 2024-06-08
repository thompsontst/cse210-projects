using System;

namespace EventManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
          

            Address address1 = new Address("241 SDP St", "EKET", "AKS", "524101");
            Address address2 = new Address("230 Ile Ogbo Street", "Ikeja", "Lagos", "100271");
            Address address3 = new Address("423 Aba Road", "Porthacourt", "Rivers", "450251");

       
        Lecture lecture = new Lecture("C# Programming", "An introduction to C#", new DateTime(2024, 6, 22), new TimeSpan(10, 0, 0), address1, "Aniekan Thompson", 120);
        Reception reception = new Reception("Hamster Properties", "Team Buliding Reception", new DateTime(2024, 7, 18), new TimeSpan(19, 0, 0), address2, "rsvp@hamsterproperties.org");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Summer Camp", "Let's Shake some things Off", new DateTime(2024, 7, 30), new TimeSpan(10, 0, 0), address3, "Sunny with a chance of rain");

        Event[] events = { lecture, reception, outdoorGathering };

        foreach (var eventItem in events)
        {
            Console.WriteLine("\nAdvertisement Message:\n" + eventItem.DisplayAdertisementMessage() + "\n");
            Console.WriteLine("Standard Details:\n" + eventItem.DisplayEventStandardDetails());
            Console.WriteLine("\nFull Details:\n" + eventItem.GetFullDetails());
            Console.WriteLine("\nShort Description:\n" + eventItem.DisplayShortDescription());
            Console.WriteLine("\n" + new string('-', 40) + "\n");
        }
        }
    }

   
    }

  

    
    


