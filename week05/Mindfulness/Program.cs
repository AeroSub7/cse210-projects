using System;
// Added system to reuse prompts so that they are no repeats until used at least once. And tells user about repeats in the reflection activity.
// Also added option to see what they listed in the listing activity.
class Program
{
    static void Main(string[] args)
    {
        BreathingActivity a1 = new BreathingActivity();

        // prompts and questions for the Reflection Activity
        string reflectionPromptsFileName = "reflectionactivityprompts.txt";
        string reflectionQuestionsFileName = "reflectionactivityquestions.txt";
        List<string> reflectionPrompts = [.. ReadFromFile(reflectionPromptsFileName)];
        List<string> reflectionQuestions = [.. ReadFromFile(reflectionQuestionsFileName)];
        ReflectingActivity reflectAct = new ReflectingActivity(reflectionPrompts, reflectionQuestions);

        // prompts for the Listing Activity
        string listingPromptsFileName = "listingactivityprompts.txt";
        List<string> listingPrompts = [.. ReadFromFile(listingPromptsFileName)];
        ListingActivity listingAct = new ListingActivity(listingPrompts);

        List<string> menuOptions = new List<string> { "Start breathing activity", "Start reflecting activity", "Start listing activity", "Display list", "quit" };
        string userResponse = "";
        do
        {
            MenuDisplay(menuOptions);
            userResponse = Console.ReadLine();
            if (userResponse == "1")
            {
                a1.Run();
            }
            else if (userResponse == "2")
            {
                reflectAct.Run();
            }
            else if (userResponse == "3")
            {
                listingAct.Run();
            }
            else if (userResponse == "4")
            {
                listingAct.DisplayResponses();
            }

        } while (userResponse != "5");



    }
    static List<string> ReadFromFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        List<string> fileLines = [.. lines];
        return fileLines;
    }
    static void MenuDisplay(List<string> options)
    {
        Console.Clear();
        Console.WriteLine("Menu Options:");
        int i = 0;
        foreach (string option in options)
        {
            i++;
            Console.WriteLine($"  {i}. {option}");
        }
        Console.Write("Select a choice form the menu: ");
    }

}