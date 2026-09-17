using System;

public class Reference
{
    //Variables
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    //Constructors
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = 0;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }
    public Reference(int line, string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        string[] parts = lines[line].Split(",");
        _book = parts[0];
        _chapter = int.Parse(parts[1]);
        _verse = int.Parse(parts[2]);
        if (parts.Length > 3)
        {
            _endVerse = int.Parse(parts[3]);
        }
        else
        {
            _endVerse = 0;
        }
    }
    //Methods
    public string GetDisplayText()
    {
        if (_endVerse == 0)
        {
            return _book + " " + _chapter + ":" + _verse;
        }
        else
        {
            return _book + " " + _chapter + ":" + _verse + "-" + _endVerse;
        }
    }
}
