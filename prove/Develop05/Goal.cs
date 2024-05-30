
using System;

public class Goal
{
    protected string _goalName;
    protected string _goaDescription;
    protected int _goalPoints;
    protected bool _goalStatus;

    public Goal() 
    {
        _goalName= "Goal Name";
        _goaDescription= "Goal Description";
        _goalPoints = 80;
        _goalStatus = false;
    }

    public Goal(string name, string description, int goalPoints)
    {
        _goalName = name;
       _goaDescription= description;
        _goalPoints = goalPoints;
    }

    protected void SetGoalBase() 
    {   
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();
        
        Console.Write("What is a short description of it? ");
        _goaDescription = Console.ReadLine();
        
        Console.Write("What is the amount of points associated with this goal? ");
        string goalPoints = (Console.ReadLine());
        _goalPoints = int.Parse(goalPoints);

        _goalStatus = false;
    }

    public virtual string SaveGoals()
    {
        string line = "";
        return line;
    }

    public virtual void SubGoals()
    {

    }

    public virtual void RecordEvent() 
    {

    }

    public virtual bool IsComplete() 
    {
        return false;
    }

    public virtual void ListOfGoals() 
    {

    }

    public virtual int SumGoalPoint()
    {
        return 0;
    }
}
