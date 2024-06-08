using System;

namespace EventManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
          

            Address address1 = new Address("123 Main St", "Springfield", "IL", "62701");
            Address address2 = new Address("456 Elm St", "Metropolis", "NY", "10001");
            Address address3 = new Address("789 Oak St", "Gotham", "NJ", "07001");

       
        Lecture lecture = new Lecture("Python Programming", "An introduction to Python", new DateTime(2024, 7, 1), new TimeSpan(10, 0, 0), address1, "John Doe", 100);
        Reception reception = new Reception("Company Gala", "Annual company gathering", new DateTime(2024, 8, 15), new TimeSpan(18, 0, 0), address2, "rsvp@company.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Community BBQ", "A fun day in the park", new DateTime(2024, 9, 10), new TimeSpan(12, 0, 0), address3, "Sunny with a chance of rain");

        Event[] events = { lecture, reception, outdoorGathering };

        foreach (var eventItem in events)
        {
            Console.WriteLine("Standard Details:\n" + eventItem.GetStandardDetails());
            Console.WriteLine("\nFull Details:\n" + eventItem.GetFullDetails());
            Console.WriteLine("\nShort Description:\n" + eventItem.GetShortDescription());
            Console.WriteLine("\n" + new string('-', 40) + "\n");
        }
        }
    }

   
    }

  

    
    


