using System;
using System.Collections.Generic;
using System.Linq;

public class MathAssigment : Assignment
{
    protected string _textbookSection = "";
    protected string _problems = "";

    public MathAssigment(string textbookSection, string problems, string student, string topic) : base(student, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Probems {_problems}";
    }
}