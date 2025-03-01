using System;
using System.Collections.Generic;
using System.Linq;

public class Class1
{
    protected string _athore = "";
    protected string _title = "";

    public string GetAthore()
    {
        return _athore;
    }

    public void SetAthore(string athore)
    {
        _athore = athore;
    }

    public void SetTitle(string title)
    {
        _athore = title;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetBookInfo()
    {
        return ($"{_title} by {_athore}");
    }
}