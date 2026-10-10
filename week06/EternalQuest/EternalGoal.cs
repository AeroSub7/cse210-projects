using System;

public class EternalGoal : Goal
{

    private int _amountCompleted;

    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        _amountCompleted = 0;
    }
    private EternalGoal(string name, string description, int points, int amountCompleted) : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
    }
    public override bool IsComplete()
    {
        return false;
    }

    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }
    public override string SaveGoal()
    {
        return $"EternalGoal^{GetShortName()}^{GetDescription()}^{GetPoints()}^{_amountCompleted}";
    }
    public static new EternalGoal LoadGoal(string line)
    {
        string[] parts = line.Split("^");
        int points = int.Parse(parts[3]);
        int amountCompleted = int.Parse(parts[4]);
        EternalGoal goal = new EternalGoal(parts[1], parts[2], points, amountCompleted);
        return goal;
    }
    public override string GetDetailsString()
    {
        return $"[ ] {GetShortName()} ({GetDescription()}) # of times completed: {_amountCompleted}";
    }
}
