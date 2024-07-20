public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 0) { }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(1);

        int timePerBreath = 6;
        int cycles = _duration / timePerBreath;

        for (int i = 0; i < cycles; i++)
        {
            Console.WriteLine();
            Console.Write("Breathe in...");
            ShowCountDown(4);
            Console.Write("Now breathe out...");
            ShowCountDown(6);
            Console.WriteLine();
        }
        
        DisplayEndingMessage();
    }
}
