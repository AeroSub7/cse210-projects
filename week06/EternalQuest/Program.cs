using System;
// Exceeding Requirements: I added when you chose to load it brings up all the files saved and you can chose out of them which file to load too or to go back to main menu.
// also added small changes here and there like Player name and an automatic save to the same file that was loaded if you want to. learned about static functions a little to load the goals back up.
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter Player's Name: ");
        string name = Console.ReadLine();
        GoalManager goalManager = new GoalManager(name);
        goalManager.Start();
    }
}