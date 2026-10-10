using System;

public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        if (IsComplete())
        {
            return $"[X] {_shortName} ({_description})";
        }
        return $"[ ] {_shortName} ({_description})";
    }
    public virtual int GetPoints()
    {
        return _points;
    }
    public string GetShortName()
    {
        return _shortName;
    }
    public string GetDescription()
    {
        return _description;
    }
    public static Goal LoadGoal(string line)
    {
        SimpleGoal goal = new SimpleGoal("", "", 0);
        return goal;
    }
    public abstract string SaveGoal();
}