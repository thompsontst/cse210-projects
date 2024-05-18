using System;

class Program
{
    static void Main(string[] args)
    {
      Reference scriptureReference = new Reference ("Proverbs", 3, 5, 6);
      Scripture scripture = new Scripture (scriptureReference, "Trust in the Lord with all your heart and lean not on. your own understanding; in all your ways submit to. Him, and He will make your paths straight.");
      Word memorizeScripture = new Word(scripture);

      string userInput = "";

    while (true)
    {
        if (userInput != "quit" && memorizeScripture.IsHidden() == true)
        {
        Console.Clear();
        Console.WriteLine(string.Format("{0} {1}", scriptureReference.GetDisplayText(), memorizeScripture.GetDisplayText()));
        Console.WriteLine();
        userInput= Console.ReadLine();
        memorizeScripture.Hide();    
    
        Console.Clear();
        Console.WriteLine(string.Format("{0} {1}", scriptureReference.GetDisplayText(), memorizeScripture.GetDisplayText()));
        Console.WriteLine();
        Console.WriteLine("Welldone you have memorize pro. 3:5-6");
    }
    }
    }
}