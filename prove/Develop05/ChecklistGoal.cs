public class ChecklistGoal : Goal
{
    public int AmountCompleted { get; set; }
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        AmountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        AmountCompleted++;
    }

    public override bool IsComplete()
    {
        return AmountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return base.GetDetailsString() + $" (Completed {AmountCompleted}/{_target} times)";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{AmountCompleted},{_target},{_bonus}";
    }
}
