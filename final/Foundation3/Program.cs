using System;

namespace EventManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create Address instances
            Address address1 = new Address("123 Main St", "Springfield", "IL", "62701");
            Address address2 = new Address("456 Elm St", "Metropolis", "NY", "10001");
            Address address3 = new Address("789 Oak St", "Gotham", "NJ", "07001");

            // Create Event instances
            Conference conference = new Conference("Tech Innovators Conference", "2024-07-20", address1, new string[] { "Alice Johnson", "Bob Smith" });
            Concert concert = new Concert("Summer Music Fest", "2024-08-15", address2, new string[] { "The Rock Band", "Jazz Ensemble" });
            Workshop workshop = new Workshop("Creative Writing Workshop", "2024-09-10", address3, new string[] { "Fiction", "Poetry", "Screenwriting" });

            // Generate marketing messages
            Event[] events = { conference, concert, workshop };
            foreach (var eventItem in events)
            {
                Console.WriteLine(eventItem.DisplayAdertisementMessage());
            }
        }
    }

   
    }

  

    
    


