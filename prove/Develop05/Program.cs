
using System;

class Program
{
    static void Main(string[] args)
    {
        string menu = "";

        GoalManager goals = new GoalManager();

    while (menu != "6") {

        int points = goals.GetScores();

        Console.WriteLine($"You have {points} points.");
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goals");
        Console.WriteLine("  5. Record Event");
        Console.WriteLine("  6. Quit");
        Console.Write("Select a choice from the menu: ");

        menu = Console.ReadLine();

        switch (menu) {
            case "1":

                Console.WriteLine("The Types of Goals are: ");
                Console.WriteLine("  1. Simple Goal");
                Console.WriteLine("  2. Eternal Goal");
                Console.WriteLine("  3. Checklist Goal");
                Console.Write("Which type of goal would you like to create? ");
                string goalType = Console.ReadLine();

                switch (goalType) {
                    case "1":
                        SimpleGoals simpleGoal = new SimpleGoals();
                        simpleGoal.SubGoals();
                        goals.addGoal(simpleGoal);
                        break;
                    
                    case "2":
                        EternalGoal eternalGoal = new EternalGoal();
                        eternalGoal.SubGoals();
                        goals.addGoal(eternalGoal);
                        break;

                    case "3":
                        ChecklistGoal checklistGoal = new ChecklistGoal();
                        checklistGoal.SubGoals();
                        goals.addGoal(checklistGoal);
                        break;
                    
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }
                break;

            case "2":
                goals.ListGoals();
                break;

            case "3":
                goals.SaveGoals();
                break;

            case "4":
                goals.LoadGoals();
                break;

            case "5":
                goals.RecordEventInTracker();
                break;

            case "6":
                Environment.Exit(0);
                break;

            default:
                Console.WriteLine("Please select a valid number from the menu options.");
                break;
            }
        }
    }
}
