using System;
using System.Collections.Generic;
using System.Linq;

public class Assignment
{
    protected string _studentName = "";
    protected string _topic = "";

    public Assignment(string student, string topic)
    {
        _studentName = student;
        _topic = topic;
    }

    public string GetStudent()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public string GetSummary()
    {
        return _studentName + " - " + _topic;
    }
}