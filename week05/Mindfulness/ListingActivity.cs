using System;
using System.ComponentModel.DataAnnotations;

public class ListingActivity : Activity
{
    private int _count = 0;
    private List<string> _prompts;
    private List<string> _usedPrompts;
    private List<string> _responses;

    public ListingActivity(List<string> prompts) : base()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _prompts = [.. prompts];
        _usedPrompts = new List<string>();
        _responses = new List<string>();
    }

    public void Run()
    {
        DisplayStaringMessage();
        GetRandomPrompt();
        _responses = [.. GetListFromUser()];
        DisplayEndingMessage();

    }
    public void GetRandomPrompt()
    {
        if (_prompts.Count == 0)
        {
            _prompts = [.. _usedPrompts];
        }
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, _prompts.Count);
        string prompt = _prompts[number];
        _usedPrompts.Add(prompt);
        _prompts.RemoveAt(number);
        Console.WriteLine($"List as many responses as you can to the following prompt:\n --- {prompt}");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
    }
    public List<string> GetListFromUser()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        DateTime currentTime = DateTime.Now;
        List<string> responses = new List<string>();
        while (currentTime < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            responses.Add(response);
            _count++;
            currentTime = DateTime.Now;
        }
        Console.WriteLine($"You listed {_count} items!\n");
        _count = 0;
        return responses;
    }
    // For displaying the list.
    public void DisplayResponses()
    {
        Console.Clear();
        if (_responses.Count != 0)
        {
            Console.WriteLine("You put in the list:");
            foreach (string response in _responses)
            {
                Console.WriteLine(response);
                ShowSpinner(3);
            }
        }
        else
        {
            Console.WriteLine("Do the Listing Activity to make a list.");
            ShowSpinner(5);
        }

    }
}