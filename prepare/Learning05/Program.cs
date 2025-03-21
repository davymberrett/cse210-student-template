using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Shapes> shapes = new List<Shapes>();

        Square s1 = new Square("Red", 3.4);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Yellow", 4, 6);
        shapes.Add(s2);

        Circle s3 = new Circle("Green", 17);
        shapes.Add(s3);

        foreach (Shapes s in shapes)
        {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area:F2}.");
        }
    }
}