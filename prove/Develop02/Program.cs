using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Console.WriteLine("Welcome to the program!");

    bool startProgram = true;
    while (startProgram)
    {
        Console.WriteLine("Please select one the following choices: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. quit");
        Console.WriteLine(" What would you Like to do? ");
        int makeChoice = int.Parse(Console.ReadLine());
        Console.WriteLine();
    switch (makeChoice)
    {
        case 1:
        journal.AddEntry();
        Console.WriteLine();
        break;

    case 2:
        journal.DisplayAll();
        Console.WriteLine();
        break;
    case 3:
    
    Console.WriteLine("Enter the file name you want to load");
    string loadFile = Console.ReadLine();
    journal.LoadFromFile(loadFile);
    Console.WriteLine();
    break;

case 4:
    
    Console.WriteLine("Enter the file name you want to save");
    string saveFile = Console.ReadLine();
    journal.SaveToFile(saveFile);
    Console.WriteLine("Your file is saved!!! ");
    Console.WriteLine();
    break;
case 5:
    
    startProgram = false;
    Console.WriteLine("Thank You for your time, have a nice day, we hope to see you again bye.... ");
    Console.WriteLine();
    break;

    default:
    Console.WriteLine("Invalid option, Please choose Numbers 1 - 5; Thank you");
   break;
   Console.WriteLine();
    }
    }

}
}
   
