using System;

namespace Exerciseracking
{
public class Swimming : Activity
{
    private int _swimminglaps;

    public Swimming(DateTime date, int lengthInMinutes, int swimminglaps)
        : base(date, lengthInMinutes)
    {
        _swimminglaps = swimminglaps;
    }

    public override double DisplayDistanceCovered()
    {
        double swimmingLap = _swimminglaps * 50 / 1000.0;
        double result = Math.Round(swimmingLap, 2);
        return result;
    }

    public override double DisplaySpeed()
    {
        double speed =  (DisplayDistanceCovered() / GetLengthOfTime()) * 60;
        double result = Math.Round(speed, 2);
        return result;
    }

    public override double DisplayPace()
    {
        double pace =  GetLengthOfTime() / DisplayDistanceCovered();
        double result = Math.Round(pace, 2);
        return result;
    }

     public override void DisplayexerciseSummary()
    {
        Console.WriteLine( $"{GetDateTime().ToString("dd MMM yyyy")} {this.GetType().Name} ({GetLengthOfTime()} min): " +
               $"Distance: {DisplayDistanceCovered():0.0} km,  Speed: {DisplaySpeed()} KPh, Pace: {DisplayPace()} Min/KM");
    }
}
}