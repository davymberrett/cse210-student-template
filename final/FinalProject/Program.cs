using System;
using System.IO;
using System.Collections.Generic;

class Program 
{
    static University university = new University("Example University", "Example City");
    
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear(); // Clear the console screen
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Find by ID");
            Console.WriteLine("2. Look Up Majors and Classes");
            Console.WriteLine("3. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    FindByID();
                    break;
                case "2":
                    LookUpMajors();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void FindByID()
    {
        Console.WriteLine("Enter ID:");
        string id = Console.ReadLine();
        university.FindByID(id);
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine(); // Wait for the user to press Enter
    }

    static void LookUpMajors()
    {
        university.LoadDepartmentsFromFile("MajorDataBase.txt");
        university.LoadMajorClassesFromFile("MajorClasses.txt"); // Ensure this is called
    
        Console.WriteLine("Available Departments:");
        university.DisplayDepartments();
    
        Console.WriteLine("\nEnter the name of the department to view its majors:");
        string departmentName = Console.ReadLine();
        university.DisplayMajors(departmentName);
    
        Console.WriteLine("\nEnter the name of a major to view its required classes:");
        string majorName = Console.ReadLine();
        university.DisplayClasses(departmentName, majorName);
    
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine(); // Wait for the user to press Enter
    }
}