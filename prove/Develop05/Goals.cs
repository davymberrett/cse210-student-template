using System;
using System.Collections.Generic;
using System.IO;

public class Goals
{
    public string Number { get; set; }
    public string Name { get; set; }
    public string Desc { get; set; }
    public int Point { get; set; }

    public Goals(string number, string name, string desc, int point)
    {
        Number = number;
        Name = name;
        Desc = desc;
        Point = point;
    }

    public virtual void DisplayGoal()
    {
        Console.WriteLine($"Goal: {Number}, Name: {Name}, Description: {Desc}, Points: {Point}");
    }

    public virtual string ToCsv()
    {
        return $"{Number},{Name},{Desc},{Point}";
    }

    public static Goals FromCsv(string csv)
    {
        string[] parts = csv.Split(',');
        if (parts.Length == 4)
        {
            return new Goals(parts[0], parts[1], parts[2], int.Parse(parts[3]));
        }
        throw new ArgumentException("Invalid CSV format");
    }
}