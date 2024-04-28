using System;

class Program
{
    static void Main(string[] args)
    {
        // ask the user for their firstname
        Console.Write("what is  your first name? ");
        string firstName = Console.ReadLine();
        
        // Ask the user for their Last name
        Console.Write("What is  your Last Name? ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");

    }
}