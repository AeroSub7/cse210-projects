using System;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the grade between (100-0): ");
        int grade = int.Parse(Console.ReadLine());
        string letter;
        bool pass = false;
        string sign = "";
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (grade >= 60 && grade <= 93)
        {
            int gradeSign = grade % 10;
            if (gradeSign >= 7)
            {
                sign = "+";
            }
            else if (gradeSign <= 3)
            {
                sign = "-";
            }
        }

        Console.Write($"Your grade is {letter}{sign}.");

        if (grade >= 70)
        {
            pass = true;
        }
        if (pass == true)
        {
            Console.WriteLine(" Congratulations, you passed the class");
        }
        else
        {
            Console.WriteLine(" Better luck next time, you did not pass the class. You can improve next time.");
        }
    }
}