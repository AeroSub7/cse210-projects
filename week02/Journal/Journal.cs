using System;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        Console.Write($"Today's prompt: {newEntry._promptText} Response: ");
        newEntry._entryText = Console.ReadLine();
        DateTime date = DateTime.Now;
        newEntry._date = date.ToShortDateString();

        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string file)
    {
        
    }

    public void LoadFromFile(string file)
    {
        
    }

}