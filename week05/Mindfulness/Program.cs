using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity a1 = new BreathingActivity();
        a1.Run();

        // prompts and questions for the Reflection Activity
        string reflectionPromptsFileName = "reflectionactivityprompts.txt";
        string reflectionQuestionsFileName = "reflectionactivityquestions.txt";
        List<string> reflectionPrompts = [.. ReadFromFile(reflectionPromptsFileName)];
        List<string> reflectionQuestions = [.. ReadFromFile(reflectionQuestionsFileName)];

        // prompts for the Listing Activity
        string listingPromptsFileName = "listingactivityprompts.txt";
        List<string> listingPrompts = [.. ReadFromFile(listingPromptsFileName)];
    }
    static List<string> ReadFromFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        List<string> fileLines = [.. lines];
        return fileLines;
    }

}