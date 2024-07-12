using System;

class Program
{
    static void Main(string[] args)
    {
        WritingAssignment write = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(write.GetSummary());
        Console.WriteLine(write.GetWritingInformation());

        MathAssignment maths = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(maths.GetSummary());
        Console.WriteLine(maths.GetHomeworkList());
    }
}