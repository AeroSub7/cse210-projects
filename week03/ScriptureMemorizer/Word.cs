using System;

public class Word
{
    //Variables
    private string _text;
    private bool _isHidden;
    //Constructors
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }
    //Methods
    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        if (!_isHidden)
        {
            return _text;
        }
        else
        {
            return Concealer();
        }
    }
    private string Concealer()
    {
        char[] letters = _text.ToCharArray();
        for (int i = 0; i < _text.Length; i++)
        {
            letters[i] = '_';
        }
        string hiddenText = new string(letters);
        return hiddenText;
    }
}