public class ReflectingActivity : Activity
{
    protected List<string> _unusedPrompts;
    protected List<string> _unusedQuestions;
    protected List<string> _prompts = new List<string>
    {
        " ------ Think of a time when you stood up for somone else ------",
        " ------ Think of a time when you did something really difficult ------",
        " ------ Think of a time when you helped someone in need ------",
        " ------ Think of a time when you did something truly selfless ------",
    };

    protected List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is yoru favourite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0)
    {
        _unusedPrompts = new List<string>(_prompts);
        _unusedQuestions = new List<string>(_questions);
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Write("Get Ready ");
        ShowSpinner(1);
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt: ");
        DisplayPrompt();
        DisplayQuestions();
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        if (_unusedPrompts.Count == 0)
        {
            _unusedPrompts = new List<string>(_prompts);
        }
        Random random = new Random();
        int index = random.Next(_unusedPrompts.Count);
        string prompt = _unusedPrompts[index];
        _unusedPrompts.RemoveAt(index);
        return prompt;
    }

    public string GetRandomQuestion()
    {
        if (_unusedQuestions.Count == 0)
        {
            _unusedQuestions = new List<string>(_questions);
        }
        Random random = new Random();
        int index = random.Next(_unusedQuestions.Count);
        string questions = _unusedQuestions[index];
        _unusedQuestions.RemoveAt(index);
        return questions;
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine();
    }

    public void DisplayQuestions()
    {
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();
        DateTime endTime = DateTime.Now.AddSeconds(_duration); // this._duration should be in seconds
        while (DateTime.Now < endTime)
        {
            string questions = GetRandomQuestion();
            Console.WriteLine(questions);
            ShowSpinner(1);
        }

    }
}
