using System;
namespace week04_developer
{

public class ListingActivity : Activity
{
protected List<string> _prompts;

        public ListingActivity(): base()
        {
            _name = "Listing Activity";
            _description =  "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                        
        }
    public void RunListingActivityProgram()
     {
        ActivityPattern();
        DisplayPrompt();
        CountList();
        DisplayEndingMessage();
                    
                  }          
                            
    public void DisplayPrompt()
    {

        _prompts = new List<string>()
            {
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "When have you felt the Holy Ghost this month?",
                "Who are some of your personal heroes?",

            };

     Console.WriteLine("List as many answers as possible to cross your mind to the following prompts.: " );  
     Console.WriteLine();
        Random rand = new Random();
        int randomIndex = rand.Next(0, _prompts.Count());
        Console.WriteLine(_prompts[randomIndex]);
        Console.WriteLine();

         Console.WriteLine("Press the Enter Key to Write your Response please quit to stop" );  
        Console.ReadLine();

    }

        public void CountList()
    {
         DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);  
        DateTime currentTime = DateTime.Now;
        int count = 0;
        while (currentTime < futureTime)
        {
            Console.Write("~ ");
            Console.ReadLine();
            count += 1;
            currentTime = DateTime.Now;
        }
        Console.WriteLine();
        Console.WriteLine($"You listed {count} items.");
        ShowSpinner(5);

    }      
}
}




