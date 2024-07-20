using System.Linq.Expressions;
using System.Runtime.CompilerServices;

public class ListingActivity : Activity
{
    protected int _count;
    protected List<string> _unusedPrompts;
    protected List<string> _prompts = new List<string>
    {
        "Who are peole that your appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0)
    {
        _unusedPrompts = new List<string>(_prompts);
    }

    public void GetRandomPrompt()
    {
        if (_unusedPrompts.Count == 0)
        {
            _unusedPrompts = new List<string>(_prompts);
        }
        Random random = new Random();
        int index = random.Next(_unusedPrompts.Count);
        string prompt = _unusedPrompts[index];
        _unusedPrompts.RemoveAt(index);
        Console.WriteLine(prompt);
    }

    public List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        DateTime endTime = DateTime.Now.AddSeconds(_duration); // this._duration should be in seconds
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                items.Add(input);
            }
        }

        Console.WriteLine();
        Console.WriteLine($"You entered {items.Count} items!");
        return items;
    }


    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(1);
        Console.WriteLine("List as many responses you can to the following prompt:");

        GetRandomPrompt();

        GetListFromUser();
        DisplayEndingMessage();
    }
}