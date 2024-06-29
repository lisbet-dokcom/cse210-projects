using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string grade = Console.ReadLine();
        int x = int.Parse(grade);
        string letter;
        int last = x % 10;
        string sign;

        if (x >= 90)
        {
            letter = "A";
        }
        else if (x >= 80)
        {
            letter = "B";
        }
        else if (x >= 70)
        {
            letter = "C";
        }
        else if (x > 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (last >= 7)
        {
            sign = "+";
        }
        else if (last < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }
        if (x >= 93)
        {
            sign = "";
        }
        if (letter == "F")
        {
            sign = "";
        }
        Console.WriteLine($"Your grade is {letter}{sign}.");

        if (x > 70)
        {
            Console.WriteLine("You passed your class.");
        }
        else
        {
            Console.WriteLine("Try harder next time.");
        }
    }
}