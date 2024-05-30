using System;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();

    private int _Scores = 0;

    public int GetScores() {

        int points = _Scores;
        return points;

    }
    public void SaveGoals()
    {
        string fileName = "";
        Console.Write("What is the filename? ");
        fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            int sumOfAvg = GetScores();
            outputFile.WriteLine(sumOfAvg.ToString());
            
            foreach(Goal goal in _goals)
            {
                outputFile.WriteLine(goal.SaveGoals());
            }
        }
    }

    public void LoadGoals()
    {
        _goals.Clear(); 

        string enterFileName = "";
        Console.Write("What is the filename? ");
        enterFileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(enterFileName);

        _Scores = int.Parse(lines[0]);

        for (int i = 1; i < lines.Count(); i++ )
        {
            string[] parts = lines[i].Split("|");

            if (parts[0] == "SimpleGoal") {

                SimpleGoals simpleGoal = new SimpleGoals(parts[1], parts[2], int.Parse(parts[3]), Convert.ToBoolean(parts[4]));
                _goals.Add(simpleGoal);             

            } else if (parts[0] == "EternalGoal") {

                EternalGoal eternalGoal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                _goals.Add(eternalGoal);

            } else if (parts[0] == "ChecklistGoal") {
                
                ChecklistGoal checklistGoal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]));
                _goals.Add(checklistGoal);

            }
        }

    }

    public void ListGoals()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count(); i++) {
            Console.Write($"{i + 1}. ");
            _goals[i].ListOfGoals();
            Console.Write("\n");
        }
        Console.WriteLine();
    }

    public void addGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public int CalculateTotalAGP()
    {
        int totalAGP = _Scores;
        foreach(Goal goal in _goals) {
            totalAGP += goal.SumGoalPoint();
        }

        _Scores = totalAGP;

        return totalAGP;
    }

    public void RecordEventInTracker()
    {
        string goalIndex = "";
        Console.Write("Which goal did you accomplish? ");
        goalIndex = Console.ReadLine();
        int goalIndexInt = Convert.ToInt32(goalIndex) - 1;

        if (_goals[goalIndexInt].IsComplete() == false) {

            _goals[goalIndexInt].RecordEvent();

            int pointsEarned = _goals[goalIndexInt].SumGoalPoint();

            _Scores += pointsEarned;

            Console.WriteLine($"Congratulations! You have earned {pointsEarned.ToString()} points!");
            Console.WriteLine($"You now have {_Scores} points");

        } else {

            Console.WriteLine("You have already completed this goal.");

        }
    }
}