using System;

public class Scripture
{
    //Variables
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    //Constructors
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] parts = text.Split(' ');
        foreach (string part in parts)
        {
            Word word = new Word(part);
            _words.Add(word);
        }
    }
    public Scripture()
    {
        _reference = new Reference("1 Corinthians", 15, 22);
        string scripture = "For as in Adam all die, even so in Christ shall all be made alive.";
        string[] parts = scripture.Split(' ');
        foreach (string part in parts)
        {
            Word word = new Word(part);
            _words.Add(word);
        }
    }
    //Methods
    public void HideRandomWords(int numberToHide)
    {
        for (int i = 0; i < numberToHide; i++)
        {
            if (!IsCompletelyHidden())
            {
                Random randomGenerator = new Random();
                int number = randomGenerator.Next(0, _words.Count);
                // This is to try to hide another word if the word is already hidden.
                if (!_words[number].IsHidden())
                {
                    _words[number].Hide();
                }
                else
                {
                    i--;
                }
            }
        }
        Console.Clear();
        Console.WriteLine(GetDisplayText());
        Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
    }
    public string GetDisplayText()
    {
        string totalText = "";
        foreach (Word word in _words)
        {
            totalText = totalText + " " + word.GetDisplayText();
        }
        return _reference.GetDisplayText() + totalText;
    }
    public bool IsCompletelyHidden()
    {
        if (NotHidden() <= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public int GetHideNumber()
    {
        if (_words.Count > 7)
        {
            return _words.Count / 7;
        }
        else
        {
            return 1;
        }
    }
    private int NotHidden()
    {
        int notHidden = _words.Count;
        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                notHidden--;
            }
        }
        return notHidden;
    }
}