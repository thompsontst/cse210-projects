using System;

class Program
{
    static void Main(string[] args)
    {
          DisplayWelcome();
          string userName = PromptUserName();
          int userNum = PromptUserNumber();

          int getSquare = SquareNumber(userNum);

        DisplayResult(userName, getSquare);

    }

    static void DisplayWelcome()
    {
        Console.WriteLine("welcome to the program");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: " );
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int number)
    {
        int squaredNumbers = number * number;
        return squaredNumbers;
    }

    static void DisplayResult(string name, int number)
    {
        Console.WriteLine($"{name} the square of the number is {number}");
    }
}