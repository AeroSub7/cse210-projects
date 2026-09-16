using System;

public class Fractions
{
    private int _top;
    private int _bottom;

    public Fractions()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fractions(int top)
    {
        _top = top;
        _bottom = 1;
    }
    public Fractions(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public void GetTop()
    {
        Console.WriteLine(_top);
    }
    public void SetTop(int top)
    {
        _top = top;
    }
    public void GetBottom()
    {
        Console.WriteLine(_bottom);
    }
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }
    public string GetFractionString()
    {
        string name = _top + "/" + _bottom;
        return name;
    }
    public double GetDecimalValue()
    {
        return (double)_top/_bottom;
    }
}