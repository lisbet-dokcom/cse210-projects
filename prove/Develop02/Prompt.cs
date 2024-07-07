public class Prompt
{
    public List<string> _prompt = new List<string>();

    public Prompt()
    {
        _prompt.Add("What is one thing you are grateful for today, and why? ");
        _prompt.Add("Describe a moment when you felt truly happy ");
        _prompt.Add("What goal were you able to achieve today and how did you go about achieving it? ");
        _prompt.Add("Write about a challenge you faced and how you overcame it. ");
        _prompt.Add("Reflect on a person who has positively influenced you day and explain how.");
        _prompt.Add("What is one thing you learned today, and why is it important to you? ");
    }
    public string GetRandomPrompt()
    {
        if (_prompt.Count == 0)
        {
            return "No prompts available";
        }

        Random random = new Random();
        int index = random.Next(_prompt.Count);
        return _prompt[index];
    }
}