using System;

using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private string _player;

    public GoalManager(string name)
    {
        _score = 0;
        _goals = new List<Goal>();
        _player = name;
    }

    public void Start()
    {
        string userResponse;
        do
        {
            MenuDisplay("", [], "");
            userResponse = Console.ReadLine();
            if (userResponse == "1")
            {
                MenuDisplay("The types of Goals are", ["Simple Goal", "Eternal Goal", "Checklist Goal"], "Type of goal would you like to create");
                userResponse = Console.ReadLine();
                CreateGoal(userResponse);
            }
            else if (userResponse == "2")
            {
                ListGoalDetails();
            }
            else if (userResponse == "3")
            {
                SaveGoals();
            }
            else if (userResponse == "4")
            {
                LoadGoals();
            }
            else if (userResponse == "5")
            {
                RecordEvent();
            }
        } while (userResponse != "6");
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"{_player} has {_score} points.\n");
    }
    public void ListGoalNames()
    {
        List<string> goals = new List<string>();
        foreach (Goal goal in _goals)
        {
            goals.Add(goal.GetShortName());
        }
        MenuDisplay("The goals are", goals, "Whcih goal did you accomplish");
    }
    public void ListGoalDetails()
    {
        List<string> goals = new List<string>();
        foreach (Goal goal in _goals)
        {
            goals.Add(goal.GetDetailsString());
        }
        MenuDisplay("The goals are", goals, "Press enter to return to Main Menu");
        Console.ReadLine();
    }
    public void CreateGoal(string type)
    {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {

            SimpleGoal goal = new SimpleGoal(name, description, points);
            _goals.Add(goal);
        }
        else if (type == "2")
        {

            EternalGoal goal = new EternalGoal(name, description, points);
            _goals.Add(goal);
        }
        else if (type == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(goal);
        }
    }
    public void RecordEvent()
    {
        ListGoalNames();
        int goalChoice = int.Parse(Console.ReadLine());
        _goals[goalChoice - 1].RecordEvent();
        _score = _score + _goals[goalChoice - 1].GetPoints();
    }
    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        File.Delete(fileName);
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"{_score}");
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine($"{goal.SaveGoal()}");
            }
        }
    }
    public void LoadGoals()
    {
        string savedFilesDirectory = AppDomain.CurrentDomain.BaseDirectory;
        if (savedFilesDirectory.Contains("\\bin\\Debug\\net10.0\\"))
        {
            savedFilesDirectory = savedFilesDirectory.Replace("bin\\Debug\\net10.0\\", "");
        }
        List<string> savedFiles = [.. Directory.GetFiles(savedFilesDirectory, "*.txt")];
        savedFiles.Add("Main Menu");
        MenuDisplay("Current Saved Files", savedFiles, "Select the goal file from the saved files");
        int fileChoice = int.Parse(Console.ReadLine());

        if (fileChoice < savedFiles.Count)
        {
            _goals.Clear();
            string[] lines = File.ReadAllLines(savedFiles[fileChoice - 1]);
            _score = int.Parse(lines[0]);
            foreach (string line in lines[1..lines.Length])
            {
                string[] parts = line.Split("^");
                if (parts[0] == "SimpleGoal")
                {

                    SimpleGoal goal = SimpleGoal.LoadGoal(line);
                    _goals.Add(goal);
                }
                else if (parts[0] == "EternalGoal")
                {
                    EternalGoal goal = EternalGoal.LoadGoal(line);
                    _goals.Add(goal);
                }
                else if (parts[0] == "ChecklistGoal")
                {
                    ChecklistGoal goal = ChecklistGoal.LoadGoal(line);
                    _goals.Add(goal);
                }
            }
        }
    }
    public void MenuDisplay(string beginning, List<string> options, string ending)
    {
        if (beginning == "")
        {
            beginning = "Menu Options";
            options = ["Create New Goal", "List Goals", "Save Goals", "Load Goals", "Record Event", "Quit"];
            ending = "Select a choice form the menu";
        }
        Console.Clear();
        DisplayPlayerInfo();
        Console.WriteLine($"{beginning}:");
        int i = 0;
        foreach (string option in options)
        {
            i++;
            Console.WriteLine($"  {i}. {option}");
        }
        Console.Write($"{ending}: ");
    }

}