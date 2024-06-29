using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int x = randomGenerator.Next(1, 100);
        
        Console.Write("What is your guess? ");
        string guess = Console.ReadLine();
        int y = int.Parse(guess);

        while (y != x)
        {
            if (x > y)
            {
                Console.WriteLine("Higher");
            }
            if (x < y)
            {
                Console.WriteLine("Lower");
            }
            Console.Write("What is your guess? ");
            guess = Console.ReadLine();
            y = int.Parse(guess);
        }
        Console.WriteLine("You guessed it!");
    }
}