
public class Entry


{

public string _date;
public string _promptText;
public string _entryText;

public void GetDate()
{
    DateTime entryTime = DateTime.Now;
    _date = entryTime.ToShortDateString();
}
public void GenerateUserPrompt()
{
     List<string> prompts = new List<string>()
     {
        "Who was the most interesting person I interacted with today?",
"What was the best part of my day?",
"How did I see the hand of the Lord in my life today?",
"What was the strongest emotion I felt today?",
"If I had one thing I could do over today, what would it be?"

     };
    Random rand = new Random();
    int randomIndex = rand.Next(prompts.Count);
    _promptText = prompts[randomIndex];
    Console.WriteLine(_promptText);
}
public void Response()
{
    Console.Write("> ");
    _entryText = Console.ReadLine();
}
}
