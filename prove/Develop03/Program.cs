using System;

class Program
{
    static void Main(string[] args)
    {
        Reference refer = new Reference("Philippians", 4, 13);
        Reference refer1 = new Reference("Moroni", 10, 4, 5);

        Scripture script = new Scripture(refer, "I can do all things through Christ which strengtheneth me.");
        Scripture script1 = new Scripture(refer1, "Ask with a sincere heart, with real intent, having faith in Christ; and by the power of the Holy Ghost ye may know the truth of all things.");

        //Two scriptures are displayed. The first scripture is displayed and after guessing it hidden words,
        //the second scripture is then displayed and guessed.

        bool showFirstScripture = true;

        while (true)
        {
            Console.Clear();

            if (showFirstScripture)
            {
                Console.WriteLine(script.GetDisplayText());
            }
            else
            {
                Console.WriteLine(script1.GetDisplayText());
            }

            Console.WriteLine();
            Console.WriteLine("Press enter to hide words, or type 'quit' to exit: ");
            string input = Console.ReadLine();

            if (input == "quit")
            {
                Console.WriteLine("You quit!");
                break;
            }
            else
            {
                if (showFirstScripture)
                {
                    script.HideRandomWords(2);
                    if (script.IsCompletelyHidden())
                    {
                        showFirstScripture = false;
                    }
                }
                else
                {
                    script1.HideRandomWords(2);
                    if (script1.IsCompletelyHidden())
                    {
                        Console.Clear();
                        Console.WriteLine("All words are hidden!");
                        Console.WriteLine("The End!");
                        break;
                    }
                }
            }
        }
    }

}