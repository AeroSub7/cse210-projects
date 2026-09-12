using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public string _owner;
    public string _password;

    public void AddEntry(Entry newEntry)
    {
        Console.WriteLine($"{newEntry._promptText}");
        Console.Write("> ");
        newEntry._entryText = Console.ReadLine();
        DateTime date = DateTime.Now;
        newEntry._date = date.ToShortDateString();

        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        if (string.IsNullOrEmpty(_owner) == false)
            Console.WriteLine($"{_owner}'s Journal:");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string file)
    {
        if (string.IsNullOrEmpty(_owner))
        {
            Console.Write("Journal's _Owner: ");
            _owner = Console.ReadLine();
        }
        if (string.IsNullOrEmpty(_password))
        {
            Console.Write("Make a Password: ");
            _password = Console.ReadLine();
        }
        File.Delete(file);

        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry._date);
                outputFile.WriteLine(entry._promptText);
                outputFile.WriteLine(entry._entryText);
            }
            outputFile.WriteLine(_owner);
            outputFile.WriteLine(_password);
        }

    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();
        string[] lines = System.IO.File.ReadAllLines(file);
        for (int i = 0; i < (lines.Length - 2); i++)
        {
            if ((i % 3) == 0)
            {
                Entry newEntry = new Entry();
                _entries.Add(newEntry);
                _entries[(i / 3)]._date = lines[i];
            }
            else if ((i % 3) == 1)
            {
                _entries[(i / 3)]._promptText = lines[i];
            }
            else
            {
                _entries[(i / 3)]._entryText = lines[i];
            }
        }
        _owner = lines[lines.Length - 2];
        _password = lines[lines.Length - 1];
        Console.Write("Password: ");
        string input = Console.ReadLine();
        if (input != _password)
        {
            _entries.Clear();
            _owner = "";
            _password = "";
            Console.WriteLine("That is not the Password. Please load another file.");
        }
    }

}