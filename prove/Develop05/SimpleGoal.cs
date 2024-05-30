using System;

public class SimpleGoals : Goal
{
    public SimpleGoals()
    {
         _goalName = "Name the Simple Goal";
       _goaDescription = "Descripe your Simple Goal";
        _goalPoints = 0;
       _goalStatus = false;
    }

    public SimpleGoals(string name, string description, int goalPoints, bool status):base(name, description, goalPoints)
    {
        _goalStatus= status;
    }

    public override void SubGoals()
    {
        SetGoalBase();
    }

    public override void RecordEvent()
    {
        if (_goalStatus == false) {
            _goalStatus = true;
        } else {
            Console.WriteLine("You have already completed this goal.");
        }
    }

    public override bool IsComplete()
    {
        if (_goalStatus == true) {
            return true;
        } else {
            return false;
        }
    }

    public override void ListOfGoals()
    {
        string goalIndicated = "";
        bool status = IsComplete();
        if (status == true) {
            goalIndicated = "X";
        } else {
            goalIndicated = " ";
        }
        Console.Write($"[{goalIndicated}] { _goalName} ({_goaDescription})");
    }
    
    public override int SumGoalPoint()
    {
        bool status = IsComplete();
        int avgGoalPoint = 0;
        if (status == true) {
            avgGoalPoint = _goalPoints;
        } else {
            avgGoalPoint = 0;
        }
        return avgGoalPoint;
    }

    public override string SaveGoals()
    {
        string line = "";
        line = $"SimpleGoal:{ _goalName},{_goaDescription}{_goalPoints},{IsComplete().ToString()}";
        return line;
    }
}