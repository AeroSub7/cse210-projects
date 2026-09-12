using System;
/*Added attrubite of*/
class Program
{
    static void Main(string[] args)
    {
        
        PromptGenerator todaysPrompt = new PromptGenerator();

        todaysPrompt._prompts.Add("What did you like eating most today?");
        todaysPrompt._prompts.Add("Who did you think about most today?");
        todaysPrompt._prompts.Add("What color did you notice most today?");
        todaysPrompt._prompts.Add("What are you thankful for from today?");
        todaysPrompt._prompts.Add("Any shower thoughts for today?");
        todaysPrompt._prompts.Add("How did God bless you today?");

        Console.WriteLine("Welcome to Easy Journal.");
        string input = "";
        Journal activeJournal = new Journal();
        do
        {
            if (input != "5")
            {
                Console.WriteLine("Choose a Command:");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Save");
                Console.WriteLine("4. Load");
                Console.WriteLine("5. Quit");
                Console.Write("Command number? ");
                input = Console.ReadLine();
                if (input == "1")
                {
                    Entry nextEntry = new Entry();
                    nextEntry._promptText = todaysPrompt.GetRandomPrompt();
                    activeJournal.AddEntry(nextEntry);
                }
                else if (input == "2")
                {
                    activeJournal.DisplayAll();
                }
                else if (input == "3")
                {
                    Console.WriteLine("What is the filename?");
                    string file = Console.ReadLine();
                    activeJournal.SaveToFile(file);
                }
                else if (input == "4")
                {
                    Console.WriteLine("What is the filename?");
                    string file = Console.ReadLine();
                    activeJournal.LoadFromFile(file);
                }
                else if (input == "5")
                {
                    Console.WriteLine("Thank you for journaling!");
                }
                else
                {
                    Console.WriteLine("Please enter valid command.");
                }
            }
        } while (input != "5");

    }
}