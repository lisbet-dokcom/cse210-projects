using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your Journal.");
        string select = "Please select one of the following";
        string action = "";
        Prompt prompts = new Prompt();
        Journal journal = new Journal();

        while (action != "5")
        {
            Console.WriteLine(select);
            string[] menu = { "1. Write", "2. Display", "3. Load", "4. Save", "5. Quit" };
            foreach (string me in menu)
            {
                Console.WriteLine(me);
            }
            Console.Write("What would you like to do? ");
            action = Console.ReadLine();

            if (action == "1")
            {
                string randomPrompt = prompts.GetRandomPrompt();
                Console.WriteLine(randomPrompt);
                string entryText = Console.ReadLine();
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                journal.AddEntry(new Entry { _date = dateText, _promptText = randomPrompt, _entryText = entryText });
            }

            else if (action == "2")
            {
                journal.DisplayMethod();
            }

            else if (action == "4")
            {
                Console.WriteLine("What is the filename");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename, journal._entries);
            }

            else if (action == "3")
            {
                Console.WriteLine("What is the filename");
                string filename = Console.ReadLine();
                journal.LoadFrom(filename);
            }

            else
            {
                Console.WriteLine("Thank you. Goodbye.");
            }
        }
    }
}