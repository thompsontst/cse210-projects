
using System;

public class ChecklistGoal : Goal
{
    private int _gameBonusPoints;
    private int _goalTime;
    private int _goalTimeCounter;

    public ChecklistGoal()
    {

    }

    public ChecklistGoal(string name, string description, int goalPoints, int bonusPoints, int times, int goalTimeCounter):base(name, description, goalPoints)
    {
        
        _gameBonusPoints = bonusPoints;
        _goalTime = times;
        _goalTimeCounter = goalTimeCounter;
    }

    public override void SubGoals()
    {
        SetGoalBase();

        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _goalTime= int.Parse(Console.ReadLine());

        Console.Write("What is the bonus for accomplishing it that many times? ");
        _gameBonusPoints = int.Parse(Console.ReadLine());

        _goalTimeCounter = 0;

    }

    public override bool IsComplete() 
    {
        if (_goalTimeCounter >= _goalTime) {
            return true;
        } else {
            return false;
        }
    }
    
    public override void RecordEvent()
    {
        _goalTimeCounter ++;
    }

    public override int SumGoalPoint()
    {
        int points = 0;

        points = _goalTimeCounter * _goalPoints;

        bool status = IsComplete();

        if (status == true) {
            points += _gameBonusPoints;
        }

        return points;

    }

    public override void ListOfGoals()
    {
        string statusSymbol = "";
        bool status = IsComplete();
        if (status == true) {
            statusSymbol = "X";
        } else {
            statusSymbol = " ";
        }

        Console.Write($"[{statusSymbol}] { _goalName} ({_goaDescription}) -- Currently Completed {_goalTimeCounter}/{_goalTime}");
    }

    public override string SaveGoals()
    {
        string line = "";
        line = $"ChecklistGoal:  {_goalName},  {_goaDescription}, {_goalPoints.ToString()}, {_gameBonusPoints.ToString()},  {_goalTime.ToString()},  {_goalTimeCounter.ToString()}";
        return line;
    }

}


       
    

  

