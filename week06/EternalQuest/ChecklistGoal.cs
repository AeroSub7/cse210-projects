using System;

public class ChecklistGoal : Goal
{

    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }
    private ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted) : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
        }

    }
    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
    public override string GetDetailsString()
    {
        if (IsComplete())
        {
            return $"[X] {GetShortName()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
        }
        return $"[ ] {GetShortName()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
        
    }
    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }
    public override string SaveGoal()
    {
        return $"ChecklistGoal^{GetShortName()}^{GetDescription()}^{GetPoints()}^{_amountCompleted}^{_target}^{_bonus}";
    }
    public override int GetPoints()
    {
        if (_amountCompleted == _target)
        {
            return base.GetPoints() + _bonus;
        }
        else
        {
            return base.GetPoints();
        }
    }
    public static new ChecklistGoal LoadGoal(string line)
    {
        string[] parts = line.Split("^");
        int points = int.Parse(parts[3]);
        int amountCompleted = int.Parse(parts[4]);
        int target = int.Parse(parts[5]);
        int bonus = int.Parse(parts[6]);
        ChecklistGoal goal = new ChecklistGoal(parts[1], parts[2], points, target, bonus, amountCompleted);
        return goal;
    }
}