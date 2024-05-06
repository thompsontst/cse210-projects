using System;
using System.Collections;

// Exceed Expectation!!!
// 1. i included a method to check if a particular file exist and if it does not, i throw an error statement
// to tell the user that the file the have enter does not exist
// i included a clear function to clear out the information on a particular journal file, just in case the 
// 2. user wants to clear the infromation in their journal
//3. I asked the user to write the lesson they have learnt about life

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Console.WriteLine("Welcome to the program!");

    bool startProgram = true;
    do 
    {
        Console.WriteLine("Please select one the following choices: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Clear");
        Console.WriteLine("6. quit");
        Console.WriteLine(" What would you Like to do? ");
        
        string  makeChoice = Console.ReadLine();
        Console.WriteLine();
    
    switch (makeChoice)
    {
        case "1":
        journal.AddEntry();
        Console.WriteLine();
        break;

    case "2":
        journal.DisplayAll();
        Console.WriteLine();
        break;
    case "3":
    
    Console.WriteLine("Enter the file name you want to load");
    string loadFile = Console.ReadLine();
    journal.LoadFromFile(loadFile);
    Console.WriteLine();
    break;

case "4":
    
    Console.WriteLine("Enter the file name you want to save");
    string saveFile = Console.ReadLine();
    journal.SaveToFile(saveFile);
    Console.WriteLine("Your file is saved!!! ");
    Console.WriteLine();
    break;

case "5":
    
    Console.WriteLine("Enter the file name you want to clear");
    string clearFile = Console.ReadLine();
    journal.ClearFile(clearFile);
    Console.WriteLine();
    break;

case "6":
    
    startProgram = false;
    Console.WriteLine("Thank You for your time, have a nice day, we hope to see you again bye.... ");
    Console.WriteLine();
    break;

    default:
    Console.WriteLine("Invalid option, Please choose Numbers 1 - 6; Thank you");
   break;
 
    }
    } while (startProgram);

}
}
   
