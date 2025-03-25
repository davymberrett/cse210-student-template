using System;

public class Teacher : Person
{
    public Teacher(string id, string name) : base(id, name, "Teacher") // Pass type information
    {
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
    }
}