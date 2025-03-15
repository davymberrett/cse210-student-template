using System;
using System.Collections.Generic;
using System.Threading;

public class ChecklistGoal : Goals
{
    private int _timesCompleted;
    private int _requiredCompletions;

    public ChecklistGoal(string number, string name, string desc, int point, int requiredCompletions) : base(number, name, desc, point)
    {
        _timesCompleted = 0; // Initialize _timesCompleted to 0
        _requiredCompletions = requiredCompletions;
    }

    public int TimesCompleted
    {
        get { return _timesCompleted; }
        set { _timesCompleted = value; }
    }

    public int RequiredCompletions
    {
        get { return _requiredCompletions; }
    }

    public bool IsCompleted
    {
        get { return _timesCompleted >= _requiredCompletions; }
    }

    public void IncrementCompletion()
    {
        _timesCompleted++;
    }

    public override void DisplayGoal()
    {
        string status = IsCompleted ? "[X]" : "[ ]";
        Console.WriteLine($"{status} Checklist Goal: {Number}, Name: {Name}, Description: {Desc}, Points: {Point}, Completed: {TimesCompleted}/{RequiredCompletions} times");
    }

    public override string ToCsv()
    {
        return $"{Number},{Name},{Desc},{Point},{TimesCompleted},{IsCompleted}";
    }

    public static new ChecklistGoal FromCsv(string csv)
    {
        string[] parts = csv.Split(',');
        if (parts.Length == 6)
        {
            return new ChecklistGoal(parts[0], parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]))
            {
                TimesCompleted = int.Parse(parts[4])
            };
        }
        throw new ArgumentException("Invalid CSV format");
    }
}