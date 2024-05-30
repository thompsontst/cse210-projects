using System;

public class EternalGoal : Goal
{
    private int _counter;

    public EternalGoal()
    {
         _goalName = "";
       _goaDescription = "";
        _goalPoints = 0;
        _counter = 0;
    }
    public EternalGoal(string name, string description, int goalPoints)
    {
         _goalName= name;
        _goaDescription= description;
        _goalPoints = goalPoints;
        _counter= 0;
    }
    public override void SubGoals()
    {
        SetGoalBase();
    }

    public override void ListOfGoals()
    {
        Console.Write($"[ ] { _goalName} ({_goaDescription})");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string SaveGoals()
    {
        string PrintLine = "";
        PrintLine = $"EternalGoal:  {_goalName},  {_goaDescription},   {_goalPoints.ToString()}";
        return PrintLine;
    }

    public override void RecordEvent()
    {
        _counter ++;
    }
    public override int SumGoalPoint()
    {
        int points = _goalPoints;
        return points;
    }
}





