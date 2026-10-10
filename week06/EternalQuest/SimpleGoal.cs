using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }
    private SimpleGoal(string name, string description, int points, bool isComplete) : base(name, description, points)
    {
        _isComplete = isComplete;
    }
    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string SaveGoal()
    {
        return $"SimpleGoal^{GetShortName()}^{GetDescription()}^{GetPoints()}^{IsComplete()}";
    }
    public static new SimpleGoal LoadGoal(string line)
    {
        string[] parts = line.Split("^");
        int points = int.Parse(parts[3]);
        bool isComplete = bool.Parse(parts[4]);
        SimpleGoal goal = new SimpleGoal(parts[1], parts[2], points, isComplete);
        return goal;
    }
}