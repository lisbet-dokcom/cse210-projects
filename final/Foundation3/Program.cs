using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Anytown", "State", "Country");
        Address address2 = new Address("456 Elm St", "Othertown", "State", "Country");
        Address address3 = new Address("789 Oak St", "Sometown", "State", "Country");

        Event lecture = new Lecture("AI in 2024", "A lecture on the future of AI", new DateTime(2024, 8, 1), "10:00 AM", address1, "Dr. Smith", 100);
        Event reception = new Reception("Company Year-End Party", "An annual gathering for all employees", new DateTime(2024, 12, 15), "6:00 PM", address2, "rsvp@company.com");
        Event outdoorGathering = new OutdoorGathering("Community Picnic", "A fun day out in the park", new DateTime(2024, 7, 30), "1:00 PM", address3, "Sunny with a chance of clouds");

        List<Event> events = new List<Event> { lecture, reception, outdoorGathering };

        foreach (var ev in events)
        {
            Console.WriteLine("Standard Details:");
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine();

            Console.WriteLine("Full Details:");
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine();

            Console.WriteLine("Short Description:");
            Console.WriteLine(ev.GetShortDescription());
            Console.WriteLine();

            Console.WriteLine(new string('-', 50));
        }

    }
}