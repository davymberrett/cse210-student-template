using System;
using System.Collections.Generic;
using System.Linq;

public class WritingAssigment : Assignment
{
    protected string _title = "";

    public WritingAssigment(string title, string student, string topic) : base(student, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        string student = GetStudent();

        return $"{_title} by {student}";
    }
}