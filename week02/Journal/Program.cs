using System;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator todaysPrompt = new PromptGenerator();

        todaysPrompt._prompts.Add("What did you like eating most today?");
        todaysPrompt._prompts.Add("Who did you think about most today?");
        todaysPrompt._prompts.Add("What color did you see the most today and how does that make you feel?");
        todaysPrompt._prompts.Add("What are you thankful for from today?");
        todaysPrompt._prompts.Add("Any shower thoughts for today?");

        Console.WriteLine(todaysPrompt.GetRandomPrompt());

        Entry todaysEntry = new Entry();

        todaysEntry._promptText = todaysPrompt.GetRandomPrompt();
        todaysEntry.Display();

        Console.WriteLine("Welcome to Easy Journal. Choose a command:");
        string input = "";
        do
        {
            if (input != "quit")
            {
                Console.WriteLine("1.New Entry");
                Console.WriteLine("2.Display Current");
                Console.WriteLine("3.Save");
                Console.WriteLine("4.Load");

            }
        } while (input != "quit");

    }
}