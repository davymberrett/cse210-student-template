using System;
using System.Drawing;

public abstract class Shapes
{
    protected string _color = "";
    public Shapes(string color)
    {
        _color = color;
    }
    public string GetColor()
    {
        return _color;
    }

    protected void SetColor(string color)
    {
        _color = color;
    }
    public abstract double GetArea();
}