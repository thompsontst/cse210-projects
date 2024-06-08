using System;

namespace Exerciseracking
{ 
public abstract class Activity
{
    private DateTime _date;
    private double _LenghtOfActivitiesInMins;

    public double GetLengthOfTime(){
        return _LenghtOfActivitiesInMins;
    }
    public DateTime GetDateTime()
    {
        return _date;
    }
    public Activity(DateTime date, double lengthInMinutes)
    {
        _date = date;
        _LenghtOfActivitiesInMins = lengthInMinutes;
    }

    public abstract double DisplayDistanceCovered();
    public abstract double DisplaySpeed();
    public abstract double DisplayPace();

    public virtual void DisplayexerciseSummary()
    {
       Console.WriteLine ($"{_date.ToString("dd MMM yyyy")} {this.GetType().Name} ({_LenghtOfActivitiesInMins} min): " +
               $"Distance: {DisplayDistanceCovered():0.0} km, Speed: {DisplaySpeed():0.0} kph, Pace: {DisplayPace():0.0} min per km");
    }
}
}