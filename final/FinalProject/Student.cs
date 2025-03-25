using System;

public class Student : Person
{
    public Student(string id, string name) : base(id, name, "Student") // Pass type information
    {
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
    }
}