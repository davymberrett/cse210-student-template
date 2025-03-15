using System;
using System.Collections.Generic;
using System.Threading;

public class ETGoal : Goals
{
    public ETGoal(string number, string name, string desc) : base(number, name, desc, 0)
    {
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"ET Goal: {Number}, Name: {Name}, Description: {Desc}");
    }

    public override string ToCsv()
    {
        return $"{Number},{Name},{Desc}";
    }

    public static new ETGoal FromCsv(string csv)
    {
        string[] parts = csv.Split(',');
        if (parts.Length == 3)
        {
            return new ETGoal(parts[0], parts[1], parts[2]);
        }
        throw new ArgumentException("Invalid CSV format");
    }
}