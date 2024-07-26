using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        while (true)
        {
            Console.Clear();
            DisplayPlayerInfo();
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Record an event");
            Console.WriteLine("4. Save goals");
            Console.WriteLine("5. Load goals");
            Console.WriteLine("6. Quit");
            Console.Write("Choose an option: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    RecordEvent();
                    break;
                case "4":
                    SaveGoals();
                    break;
                case "5":
                    LoadGoals();
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Player's current score: {_score}");
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        Console.Write("Enter goal type (simple, eternal, checklist): ");
        var type = Console.ReadLine().ToLower();

        Console.Write("Enter goal name: ");
        var name = Console.ReadLine();

        Console.Write("Enter goal description: ");
        var description = Console.ReadLine();

        Console.Write("Enter goal points: ");
        var points = int.Parse(Console.ReadLine());

        Goal goal;
        switch (type)
        {
            case "simple":
                goal = new SimpleGoal(name, description, points);
                break;
            case "eternal":
                goal = new EternalGoal(name, description, points);
                break;
            case "checklist":
                Console.Write("Enter target number of times to complete: ");
                var target = int.Parse(Console.ReadLine());

                Console.Write("Enter bonus points for completion: ");
                var bonus = int.Parse(Console.ReadLine());

                goal = new ChecklistGoal(name, description, points, target, bonus);
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                return;
        }

        _goals.Add(goal);
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Enter the number of the goal you accomplished: ");
        var goalNumber = int.Parse(Console.ReadLine());
        if (goalNumber < 1 || goalNumber > _goals.Count)
        {
            Console.WriteLine("Invalid goal number.");
            return;
        }
        var goal = _goals[goalNumber - 1];
        goal.RecordEvent();
        _score += goal.GetPoints(); // Use a public method to access the points
    }


    public void SaveGoals()
    {
        using (var writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(_score);
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals()
    {
        if (!File.Exists("goals.txt"))
        {
            Console.WriteLine("No saved goals found.");
            return;
        }
        _goals.Clear();
        using (var reader = new StreamReader("goals.txt"))
        {
            _score = int.Parse(reader.ReadLine());
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var parts = line.Split(':');
                var type = parts[0];
                var data = parts[1].Split(',');
                Goal goal;
                switch (type)
                {
                    case "SimpleGoal":
                        goal = new SimpleGoal(data[0], data[1], int.Parse(data[2]));
                        if (bool.Parse(data[3]))
                        {
                            ((SimpleGoal)goal).RecordEvent();
                        }
                        break;
                    case "EternalGoal":
                        goal = new EternalGoal(data[0], data[1], int.Parse(data[2]));
                        break;
                    case "ChecklistGoal":
                        goal = new ChecklistGoal(data[0], data[1], int.Parse(data[2]), int.Parse(data[4]), int.Parse(data[5]));
                        ((ChecklistGoal)goal).AmountCompleted = int.Parse(data[3]); // Set the amount completed before adding the goal
                        break;
                    default:
                        Console.WriteLine("Unknown goal type.");
                        continue;
                }
                _goals.Add(goal);
            }
        }
        Console.WriteLine("Goals loaded successfully.");
    }

}
