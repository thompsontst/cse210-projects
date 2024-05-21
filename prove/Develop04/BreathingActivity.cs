using System;
namespace week04_developer{
    public class BreathingActivity : Activity
    {
          public BreathingActivity() : base()
        {
            _name = "Breathing Activity";
            _description = "This activity will help you relax by walking your through breathing in and out slowly. \n Clear your mind and focus on your breathing";
        }
    public void RunBreathingActivity()
    {
        ActivityPattern();
        DisplayBreathingActivity();
        DisplayEndingMessage();

    } 
    public void countDownTimer()
    {
        for (int i = 6; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b"); 
        }

    }
    public void countUpTimer()
    {
        for (int i = 1; i <= 6; i++)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b"); 

            
        }
    }
    public void DisplayBreathingActivity()
    {
        int timer = _duration * 1000;
        int timeSpace = 10000;
        int timeInterval = timer / timeSpace;
        for (int i =0; i <= timeInterval; i++)
        {
    
            Console.Write("Breathe in ....");
            countUpTimer();
            Console.WriteLine();


            
             Console.Write("Breathe out ....");
             countDownTimer();
             Console.WriteLine();
            
        }
    }
    }


}