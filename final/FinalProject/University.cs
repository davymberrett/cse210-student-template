using System;
using System.Collections.Generic;
using System.IO;

public class University
{
    public string Name { get; set; }
    public string Location { get; set; }
    public List<Student> Students { get; set; }
    public List<Teacher> Teachers { get; set; }
    private string databaseFilePath = @"C:\Users\berre\OneDrive\Desktop\Pro. Classes\cse210\cse210-student-template\final\FinalProject\Database.txt";

    public University(string name, string location)
    {
        Name = name;
        Location = location;
        Students = new List<Student>();
        Teachers = new List<Teacher>();
        LoadData();
    }

    public void AddStudent(Student student)
    {
        Students.Add(student);
        SaveData();
    }

    public void AddTeacher(Teacher teacher)
    {
        Teachers.Add(teacher);
        SaveData();
    }

    public void FindByID(string id)
    {
        id = id.Trim(); // Trim any leading or trailing whitespace

        foreach (var student in Students)
        {
            if (student.ID.Equals(id, StringComparison.OrdinalIgnoreCase))
            {
                student.DisplayInfo();
                return;
            }
        }

        foreach (var teacher in Teachers)
        {
            if (teacher.ID.Equals(id, StringComparison.OrdinalIgnoreCase))
            {
                teacher.DisplayInfo();
                return;
            }
        }

        Console.WriteLine("No student or teacher found with that ID.");
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"University: {Name}");
        Console.WriteLine($"Location: {Location}");
        Console.WriteLine("Students:");
        foreach (var student in Students)
        {
            student.DisplayInfo();
        }
        Console.WriteLine("Teachers:");
        foreach (var teacher in Teachers)
        {
            teacher.DisplayInfo();
        }
    }

    private void LoadData()
    {
        //Console.WriteLine($"Current Directory: {Directory.GetCurrentDirectory()}"); // Debugging statement

        if (!File.Exists(databaseFilePath))
        {
            Console.WriteLine($"File not found: {databaseFilePath}");
            return;
        }

        //Console.WriteLine($"Loading data from: {databaseFilePath}");

        using (StreamReader reader = new StreamReader(databaseFilePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                //Console.WriteLine($"Reading line: {line}"); // Debugging statement
                string[] parts = line.Split(',');
                string type = parts[0].Trim();
                string id = parts[1].Trim();
                string name = parts[2].Trim();

                if (type == "Student")
                {
                    var student = new Student(id, name);
                    Students.Add(student); // Add to list without saving immediately
                }
                else if (type == "Teacher")
                {
                    var teacher = new Teacher(id, name);
                    Teachers.Add(teacher); // Add to list without saving immediately
                }
            }
        }
    }

    private void SaveData()
    {
        using (StreamWriter writer = new StreamWriter(databaseFilePath))
        {
            foreach (var student in Students)
            {
                writer.WriteLine($"Student,{student.ID},{student.Name}");
            }
            foreach (var teacher in Teachers)
            {
                writer.WriteLine($"Teacher,{teacher.ID},{teacher.Name}");
            }
        }
    }
}