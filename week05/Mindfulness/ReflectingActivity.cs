using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private List<string> _usedPrompts;
    private List<string> _usedQuestions;

    public ReflectingActivity(List<string> prompts, List<string> questions) : base()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _prompts = [.. prompts];
        _questions = [.. questions];
        _usedPrompts = new List<string>();
        _usedQuestions = new List<string>();
    }

    public void Run()
    {
        DisplayStaringMessage();
        if (_prompts.Count == 0)
        {
            if (!Reuse("prompts"))
            {
                return;
            }
        }
        DisplayPrompt();
        DisplayQuestions();
        DisplayEndingMessage();
    }
    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, _prompts.Count);
        string prompt = _prompts[number];
        _usedPrompts.Add(prompt);
        _prompts.RemoveAt(number);
        return prompt;
    }
    public string GetRandomQuestion()
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, _questions.Count);
        string question = _questions[number];
        _usedQuestions.Add(question);
        _questions.RemoveAt(number);
        return question;
    }
    public void DisplayPrompt()
    {
        Console.WriteLine($"Consider the following prompt:\n\n --- {GetRandomPrompt()} ---\n\nWhen you have something in mind press enter to continue.");
        Console.ReadLine();
    }
    public void DisplayQuestions()
    {
        foreach (string question in _usedQuestions)
        {
            _questions.Add(question);
        }
        _usedQuestions.Clear();

        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();
        DateTime startTime = DateTime.UtcNow;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        DateTime currentTime = DateTime.UtcNow;
        while (currentTime < endTime)
        {
            if (_questions.Count != 0)
            {
                Console.Write($"{GetRandomQuestion()}");
                ShowSpinner(10);
            }
            else
            {
                Console.Write("No more questions at this time.");
                ShowSpinner(6);
                _questions = [.. _usedQuestions];
                _usedQuestions.Clear();
                int currentTimeNumber = (int)new DateTimeOffset(currentTime).ToUnixTimeSeconds();
                int EndTimeNumber = (int)new DateTimeOffset(endTime).ToUnixTimeSeconds();
                int timePast = GetDuration() - (EndTimeNumber - currentTimeNumber);
                SetDuration(timePast);

                return;
            }
            currentTime = DateTime.UtcNow;
        }
    }
    private bool Reuse(string type)
    {
        Console.Write($"Do you wish to reuse {type}(y)? ");
        string answer = Console.ReadLine();
        if (answer.ToLower() == "y")
        {
            if (type == "prompts")
            {
                _prompts = [.. _usedPrompts];
                _usedPrompts.Clear();
            }
            else
            {
                _questions = [.. _usedQuestions];
                _usedQuestions.Clear();
            }
            return true;
        }
        else
        {
            return false;
        }
    }
}