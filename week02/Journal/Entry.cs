using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"Entry for the {_date}. ");
        Console.WriteLine($"Responding to {_promptText}:");
        Console.WriteLine(_entryText);
    }
}