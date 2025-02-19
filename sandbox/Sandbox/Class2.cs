using System;
using System.Collections.Generic;
using System.Linq;

public class Picherbook : Book
{
    private string _illistrator = "";

    public string Getillistrator()
    {
        return _illistrator;
    }

    public void SetIllistrator(string illistrator)
    {
        _athore = illistrator;
    }
}