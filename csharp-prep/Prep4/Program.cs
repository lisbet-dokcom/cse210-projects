using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int x;

        while (true)
        {
            Console.Write("Enter a number: ");
            x = int.Parse(Console.ReadLine());

            if (x != 0)
            {
                numbers.Add(x);
            }
            else
            {
                break;
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        double average = (double)sum / numbers.Count;
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The sum is: {sum}.");
        Console.WriteLine($"The average is: {average}.");
        Console.WriteLine($"The largest number is: {max}.");
    }
}