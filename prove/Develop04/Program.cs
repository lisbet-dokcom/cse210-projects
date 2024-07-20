using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Menu Options:");
        string select = "Select from the Menu: ";
        string action = "";

        while (action != "4")
        {
            string[] menu = { "1. Breathing Activity", "2. Listing Activity", "3. Reflecting Activity", "4. Quit" };
            foreach (string me in menu)
            {
                Console.WriteLine(me);
            }
            Console.Write(select);
            action = Console.ReadLine();

            if (action == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
                Console.WriteLine();
            }

            else if (action == "2")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
                Console.WriteLine();
            }
            else if (action == "3")
            {
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
                Console.WriteLine();
            }
            else
            {
                Console.Clear();
                break;
            }
        }
    }
}