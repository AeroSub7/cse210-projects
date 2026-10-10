using System;
// Exceeding Requirements: I added when you chose to load it brings up all the files saved and you can chose out of them which file to load or to 
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