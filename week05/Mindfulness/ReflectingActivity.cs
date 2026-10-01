using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity() : base()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public void Run()
    {
        DisplayStaringMessage();
    }
    public string GetRandomPrompt()
    {
        return "";
    }
    public string GetRandomQuestion()
    {
        return "";
    }
    public void DisplayPrompt()
    {
        
    }
    public void DisplayQuestions()
    {
        
    }

}