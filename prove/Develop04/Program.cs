 using System;
 namespace week04_developer
 {

     class Program
 {
     static void Main(string[] args)
     {
        int countBreath = 0;
      int reflectAct = 0;
         int listingProgram = 0;
 Console.WriteLine("Welcome to the program!");

    bool startProgram = true;
    do 
    {
        Console.WriteLine("Please select one the following choices: ");
        Console.WriteLine("Please select one of the following activities: ");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflecting Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Quit");
        Console.WriteLine(" What would you Like to do? ");
        
        string  makeChoice = Console.ReadLine();
        Console.WriteLine();
      
    switch (makeChoice)
    {
        case "1":
        Console.Clear();
        BreathingActivity activity01 = new  BreathingActivity();
         activity01.RunBreathingActivity();
        countBreath++;
        break;

    case "2":
    Console.Clear();
        ReflectingActivity activity02 = new  ReflectingActivity();
        activity02.RunReflectingActivityProgram();
        reflectAct++;
        goto case "3";
        
         case "3":
         ListingActivity activity03 = new  ListingActivity();
         activity03.RunListingActivityProgram();
         listingProgram++;
         break;
    
    case "4":
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
 }
 