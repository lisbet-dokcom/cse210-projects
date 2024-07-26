using System;

class Program
{
    static void Main(string[] args)
    {
        // Create activities
        Activity running = new Running(new DateTime(2024, 7, 25), 30, 3.0); // 3 miles in 30 minutes
        Activity cycling = new Cycling(new DateTime(2024, 7, 24), 45, 12.0); // 12 mph for 45 minutes
        Activity swimming = new Swimming(new DateTime(2024, 7, 23), 20, 40); // 40 laps in 20 minutes

        // Store activities in a list
        List<Activity> activities = new List<Activity> { running, cycling, swimming };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}