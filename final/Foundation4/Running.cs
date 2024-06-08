using System;

namespace Exerciseracking
{
public class Running : Activity
{
    private double _distanceInKm;

    public Running(DateTime date, int lengthInMinutes, double distanceInKm): base(date, lengthInMinutes)
    {
        _distanceInKm = distanceInKm;
    }

    public override double DisplayDistanceCovered()
    {
        return _distanceInKm;
    }

    public override double DisplaySpeed()
    {
        
        double speed =  (_distanceInKm / GetLengthOfTime()) * 60;
        double result = Math. Round(speed, 2);
        return result;
    }

    public override double DisplayPace()
    {
        
        double num = GetLengthOfTime() / _distanceInKm;
        double result = Math. Round(num, 2);

        return result;
    }
     public override void DisplayexerciseSummary()
    {
        Console.WriteLine( $"{GetDateTime().ToString("dd MMM yyyy")} {this.GetType().Name} ({GetLengthOfTime()} min): " +
               $"Distance: {DisplayDistanceCovered():0.0} km,  Speed: {DisplaySpeed()} KPh, Pace: {DisplayPace()} Min/KM");
    }
}
}