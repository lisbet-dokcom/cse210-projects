using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        {
            DisplayWelcome();
            string userName = PromptUserName();
            int number = PromptUserNumber();
            int square = SquareNumber(number);
            DisplayResult(square, userName);
        }

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        static string PromptUserName()
        {
            Console.Write("Please eneter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string userNumber = Console.ReadLine();
            int number = int.Parse(userNumber);
            return number;
        }
        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }
        static void DisplayResult(int square, string userName)
        {
            Console.WriteLine($"{userName}, the square of your number is {square}.");
        }
    }
}