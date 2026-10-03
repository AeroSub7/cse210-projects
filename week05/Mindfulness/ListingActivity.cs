using System;

public class ListingActivity : Activity
{
    private int _count = 0;
    private List<string> _prompts;

    public ListingActivity(List<string> prompts) : base()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _prompts = [.. prompts];
    }

    public void Run()
    {
        DisplayStaringMessage();

        DisplayEndingMessage();

    }
    public void GetRandomPrompt()
    {

    }
    public List<string> GetListFromUser()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        List<string> responses = new List<string>();
        while (startTime < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            responses.Add(response);
            _count++;
        }
        return responses;
    }
}