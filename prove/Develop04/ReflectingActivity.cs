using System;
using System.Security.Cryptography.X509Certificates;
namespace week04_developer{
    public class ReflectingActivity:Activity
    {
        protected List<string> _prompts;
        protected List<string>_questions;
        public ReflectingActivity():base()
        {
            _name = "Reflective Activity";
            _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. \nThis will help you recognize the power you have and how you can use it in other aspects of your life.";
                        
        }
                  public void RunReflectingActivityProgram()
                  {
                    ActivityPattern();
                    DisplayPrompt();
                    DisplayQuestions();
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

     Console.WriteLine("Give a thought to the following: " );  
     Console.WriteLine();

        Random rand = new Random();
        int randomIndex = rand.Next(0, _prompts.Count());
        Console.WriteLine(_prompts[randomIndex]);
        Console.WriteLine();

         Console.WriteLine("Press the Enter Key after Writing your Response" );  
        Console.ReadLine();
    }       

    public void DisplayQuestions()
    {
            _questions = new List<string> ()
            {

                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?"
                            };
        List<int> indexes = new List<int>();

        for (int i = 0; i <= 5; i++)
        {
            int randomIndex = new Random().Next(0, _questions.Count());
    
        while ( indexes.Contains(randomIndex))
        {
            randomIndex = new Random().Next(0, _questions.Count());
        }
            indexes.Add(randomIndex);
        }
        Console.Clear();
        Console.WriteLine("Meditate and give sincere answer on the following questions ");
        Console.WriteLine();
        ShowSpinner(8);
        foreach(int index in indexes)
        {
            Console.WriteLine(_questions[index]);
            ShowSpinner((_duration/indexes.Count()));
        }
        Console.WriteLine();
    }



    
            }
    }

