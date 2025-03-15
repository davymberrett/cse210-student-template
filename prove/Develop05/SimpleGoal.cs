using System;
using System.Collections.Generic;
using System.Threading;

public class SimpleGoal : Goals
{
    private bool _completed;

    public SimpleGoal(string number, string name, string desc, int point) : base(number, name, desc, point)
    {
        _completed = false; // Initialize _completed to false
    }

    public bool IsCompleted
    {
        get { return _completed; }
        set { _completed = value; }
    }

    public void MarkComplete()
    {
        _completed = true;
    }

    public override void DisplayGoal()
    {
        string status = IsCompleted ? "[X]" : "[ ]";
        Console.WriteLine($"{status} Simple Goal: {Number}, Name: {Name}, Description: {Desc}, Points: {Point}");
    }

    public override string ToCsv()
    {
        return $"{Number},{Name},{Desc},{Point},{IsCompleted}";
    }

    public static new SimpleGoal FromCsv(string csv)
    {
        string[] parts = csv.Split(',');
        if (parts.Length == 5)
        {
            return new SimpleGoal(parts[0], parts[1], parts[2], int.Parse(parts[3]))
            {
                IsCompleted = bool.Parse(parts[4])
            };
        }
        throw new ArgumentException("Invalid CSV format");
    }
}