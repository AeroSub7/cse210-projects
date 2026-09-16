using System;
using System.Xml.Schema;

class Program
{
    static void Main(string[] args)
    {
        Fractions x = new Fractions();

        Console.WriteLine(x.GetFractionString());
        Console.WriteLine(x.GetDecimalValue());

        Fractions a = new Fractions(5);

        Console.WriteLine(a.GetFractionString());
        Console.WriteLine(a.GetDecimalValue());

        Fractions b = new Fractions(3, 4);

        Console.WriteLine(b.GetFractionString());
        Console.WriteLine(b.GetDecimalValue());

        Fractions c = new Fractions(1, 3);

        Console.WriteLine(c.GetFractionString());
        Console.WriteLine(c.GetDecimalValue());

    }
}