using System;
using System.Collections.Generic;

public class Classes
{
    public string ClassName { get; set; }
    public Teacher ClassTeacher { get; set; }
    public List<Student> Students { get; set; }

    public Classes(string className, Teacher classTeacher)
    {
        ClassName = className;
        ClassTeacher = classTeacher;
        Students = new List<Student>();
    }

    public void AddStudent(Student student)
    {
        Students.Add(student);
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Class: {ClassName}");
        if (ClassTeacher != null)
        {
            Console.WriteLine($"Teacher: {ClassTeacher.Name}");
        }
        Console.WriteLine("Students:");
        foreach (var student in Students)
        {
            student.DisplayInfo();
        }
    }
}