using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Assignment work1 = new Assignment("Eric", "do coding homework");
        string summary = work1.GetSummary();
        Console.WriteLine(summary);
        MathAssignment math1 = new MathAssignment("Eric", "Fractions", "7.3", "8-19");
        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeworkList());

        WritingAssignment writing1 = new WritingAssignment("Mary Waaters", "European History", "The Causes of World War II");
        Console.WriteLine(writing1.GetSummary());
        Console.WriteLine(writing1.GetWritingInformation());

    }
}