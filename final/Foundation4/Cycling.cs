using System;

namespace Exerciseracking
{ 
public class Cycling : Activity
{
    private double _cyclingSpeedInKpMh;

    public Cycling(DateTime date, int lengthInMinutes, double speedInKph) : base(date, lengthInMinutes)
    {
        _cyclingSpeedInKpMh = speedInKph;
    }

    public override double DisplayDistanceCovered()
    {
       
        double distance = (_cyclingSpeedInKpMh * GetLengthOfTime())/ 60;
         double result = Math. Round(distance, 2);
        return result;
    }

    public override double DisplaySpeed()
    {
        return _cyclingSpeedInKpMh;
    }

    public override double DisplayPace()
    {
        double pace =  60 / _cyclingSpeedInKpMh;
         double result = Math. Round(pace, 2);
        return result;
    }
      public override void DisplayexerciseSummary()
    {
        Console.WriteLine( $"{GetDateTime().ToString("dd MMM yyyy")} {this.GetType().Name} ({GetLengthOfTime()} min): " +
               $"Distance: {DisplayPace():0.0} km");
    }
}
}