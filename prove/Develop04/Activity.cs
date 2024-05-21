using System.Security.Cryptography.X509Certificates;

namespace week04_developer
{
    public class Activity
    {
        protected string _name;
        protected string _startMessage;
        protected string _endMessage;
        protected string _description;
        protected int _duration = 0;
 
         public void ActivityPattern()
         {
            DisplayStartingMessage();
            DisplayDescription();
            DisplayGameTime();
            DisplayGetReady();
            Console.Clear();
         }
        public void DisplayStartingMessage()
        {
            _startMessage = ($"Welcome to the {_name}");
            Console.WriteLine(_startMessage);
            Console.WriteLine();
        }
        public void DisplayDescription()
        {
            Console.WriteLine(_description);
            Console.WriteLine();
        }
        public void DisplayEndingMessage()
        {   _endMessage = ($"You have completed  {_duration} secs. of the {_name}");
            Console.WriteLine(_endMessage);
            Console.WriteLine();

        }
                public void ShowSpinner(int timer)
        
        {
            List<string> animationStrings = new List<string>();
            animationStrings.Add("/");
            animationStrings.Add("/");
            animationStrings.Add("|");
            animationStrings.Add("/");
            animationStrings.Add("-");
            animationStrings.Add("\\");
            animationStrings.Add("|");
            animationStrings.Add("/");
            animationStrings.Add("-");
            animationStrings.Add("\\");

                DateTime startTime = DateTime.Now;
                DateTime endTime = startTime.AddSeconds(timer);
                
                int i = 0;

                while (DateTime.Now < endTime)
                
                {
                    string s = animationStrings[i];
                    Console.Write(s);
                    Thread.Sleep(1000);  
                    Console.Write("\b \b");     

                    i++;

                    if (i>=animationStrings.Count)
                    {
                        i = 0;
                    }
                }
        
       
        }
        public void DisplayGetReady()
        {
            Console.WriteLine("Get ready...");
            ShowSpinner(5);
        }
        public void DisplayGameTime()
        {
          bool durationInput = true; 

           do
            {
                try{
                    Console.WriteLine("How long  in seconds do you want to play? ");
            _duration = int.Parse(Console.ReadLine());

                    durationInput = false;
                 } catch
                 {
                    Console.WriteLine("Invalid Input!!!! please enter a only numbers? ");
                     
                 }
                
                 Console.WriteLine();
            }  while(durationInput);

            
            
        }
    }
}
