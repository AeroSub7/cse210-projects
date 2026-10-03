using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
    public void Run()
    {
        DisplayStaringMessage();
        for (int i = GetDuration() / 8; i > 0; i--)
        {
            Console.Write("\nBreath in...");
            ShowCountDown(4);
            Console.Write("Now breathe out...");
            ShowCountDown(4);
        }
        DisplayEndingMessage();
    }
}