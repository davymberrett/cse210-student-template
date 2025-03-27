using System;
using System.Collections.Generic;
using System.IO;

public class Department
{
    public string Name { get; set; }
    public List<Major> Majors { get; private set; }

    public Department(string name)
    {
        Name = name;
        Majors = new List<Major>();
    }

    public void AddMajor(string majorName)
    {
        Majors.Add(new Major(majorName));
    }

    public void DisplayMajors()
    {
        Console.WriteLine($"\nMajors in {Name}:");
        foreach (var major in Majors)
        {
            Console.WriteLine($"- {major.Name}");
        }
    }

    public void DisplayClasses(string majorName)
    {
        Major major = GetMajorByName(majorName);
        if (major != null)
        {
            Console.WriteLine($"\nClasses for Major: {major.Name}");
            foreach (var className in major.Classes)
            {
                Console.WriteLine($"- {className}");
            }
        }
        else
        {
            Console.WriteLine($"No major found with the name: {majorName}");
        }
    }

    public Major GetMajorByName(string name)
    {
        return Majors.Find(major => major.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }

    public void LoadMajorsAndClassesFromFile(string filePath)
    {
        try
        {
            string[] lines = File.ReadAllLines(filePath);
            Major currentMajor = null;

            foreach (string line in lines)
            {
                string trimmedLine = line.Trim();

                if (string.IsNullOrEmpty(trimmedLine))
                    continue;

                if (trimmedLine.StartsWith("-"))
                {
                    // Add a class to the current major
                    if (currentMajor != null)
                    {
                        currentMajor.Classes.Add(trimmedLine.Substring(1).Trim());
                    }
                }
                else if (trimmedLine == ";")
                {
                    // End of the current major's classes
                    currentMajor = null;
                }
                else
                {
                    // Start a new major
                    currentMajor = new Major(trimmedLine);
                    Majors.Add(currentMajor);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading majors and classes: {ex.Message}");
        }
    }

    internal void AddMajor(Major major)
    {
        throw new NotImplementedException();
    }
}
