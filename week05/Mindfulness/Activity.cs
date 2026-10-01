using System;

public class Activity
{
    protected string _name;
    protected string _description;
    private int _duration;

    public Activity()
    {
        _duration = 0;
    }

    public void DisplayStaringMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.\n\n{_description}\n");
        Console.Write("How long, in seconds would you like for your session? ");
        do
        {
            _duration = int.Parse(Console.ReadLine());
            if (_duration < 16)
            {
                Console.Write("Please set session to be longer then 15 seconds. How long, in seconds would you like for your session? ");
            }
            else if (_duration > 300)
            {
                Console.Write("We recommend that a session is not longer then 5 minutes (300 seconds) long. How long, in seconds would you like for your session? ");
            }
        } while (_duration > 300 || _duration < 16);
        Console.WriteLine("Get ready...");
        ShowSpinner(4);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done.");
        ShowSpinner(4);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(4);
    }
    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("-");
            Thread.Sleep(200);
            Console.Write("\b \b");
            Console.Write(@"\");
            Thread.Sleep(200);
            Console.Write("\b \b");
            Console.Write(@"|");
            Thread.Sleep(200);
            Console.Write("\b \b");
            Console.Write(@"/");
            Thread.Sleep(200);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }
    public int GetDuration()
    {
        return _duration;
    }
}