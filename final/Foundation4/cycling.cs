public class Cycling : Activity
{
    public double Speed { get; set; } // in mph

    public Cycling(DateTime date, int length, double speed)
        : base(date, length)
    {
        Speed = speed;
    }

    public override double GetDistance()
    {
        return (Speed * Length) / 60;
    }

    public override double GetSpeed()
    {
        return Speed;
    }

    public override double GetPace()
    {
        return 60 / Speed;
    }
}
