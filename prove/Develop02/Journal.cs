using System.IO;
using System.Reflection.Metadata;


public class Journal
{
    public List<Entry>_entries = new List<Entry>();


public void AddEntry ()
{
Entry userEntries = new Entry();
userEntries.GetDate();
userEntries.GenerateUserPrompt();
userEntries.Response();

_entries.Add(userEntries);

}

public void ClearFile (string file)
{
    bool clearFile = false;
do
{
    
if (!File.Exists(file))
{
    Console.WriteLine("The File you have entered does not exists, please enter a correct file name");
}

else
{
    File.WriteAllText(file, "");
    Console.WriteLine("\n Your Journal is Cleared");


} 
}while(clearFile);
}
public void DisplayAll()
{
    
    foreach (Entry userEntry in _entries)
{
    Console.WriteLine($"Date: {userEntry._date}");
    Console.WriteLine($"Prompt: {userEntry._promptText}");
    Console.WriteLine($"Date: {userEntry._entryText}");
    Console.WriteLine();
}
    
    
}

public void SaveToFile(string file)
{
    using (StreamWriter outputFile = new StreamWriter(file, true))
    {
        
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"Date: {entry._date}");
                outputFile.WriteLine($"Prompt: {entry._promptText}");
                outputFile.WriteLine($"Answer: {entry._entryText}");
                outputFile.WriteLine();
            }

        }

    }

public void LoadFromFile( string file)
{
bool loadFile = false;
do
{
if (!File.Exists(file))
{
    Console.WriteLine("The File you have entered does not exists, please enter a correct file name");
}
else if (file.EndsWith(".csv"))
{
    string[] lines = File.ReadAllLines(file);
    foreach (string line in lines)
    {
        string [] parts = line.Split(",");
        string date = parts[0];
        string  prompt = parts[1];
        string entry = parts[2];
    Console.WriteLine($"Date: {date}");
    Console.WriteLine($"Prompt: {prompt}");
    Console.WriteLine($"Answer: {entry}");
    Console.WriteLine();

    }
}
    else
    {
        using(StreamReader reader = new StreamReader (file))
{
    string journalEntries = reader.ReadToEnd();
    Console.Write(journalEntries);
}
    }
    } while(loadFile);
}

}

