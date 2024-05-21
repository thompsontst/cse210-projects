
class Timer
{
    public Timer
    {
        Console.WriteLine("Hello Develop04 World! ");
       
        // Console.WriteLine(5);
        // Thread.Sleep(1000);
        //   Console.WriteLine(4);
        // Thread.Sleep(1000);
        //   Console.WriteLine(3);
        // Thread.Sleep(1000);
        //   Console.WriteLine(2);
        // Thread.Sleep(1000);
        //   Console.WriteLine(1);
        // for (int i = 5; i>0; i--) {
        // // Console.Write(i);
        // Console.Write(".");
        // Thread.Sleep(1000);
        // Console.Write("\b \b");
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
    //     foreach (string s in animationStrings) {
    //     Console.Write(s);
    //     Thread.Sleep(1000);
    //     Console.Write("\b \b");
    // }
    


    Console.WriteLine("enter the time in second ");
    int timer = int.Parse(Console.ReadLine());
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
    Console.WriteLine("\nDone");
}
}