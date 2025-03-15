using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static List<Goals> goals = new List<Goals>();
    static int goalCounter = 1;
    static int totalPoints = 0; // Field to keep track of total points

    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!"); // Display a test greeting to the user

        while (true)
        {
            Console.WriteLine("What is your choice:\n1. Save\n2. Load\n3. Create\n4. Mark Complete\n5. Exit");
            string action = Console.ReadLine();
            if (action.ToLower() == "exit")
            {
                break;
            }

            switch (action.ToLower())
            {
                case "save":
                    SaveGoals("goals.txt");
                    Console.WriteLine("Goals saved.");
                    break;
                case "load":
                    LoadGoals("goals.txt");
                    Console.WriteLine("Goals loaded.");
                    DisplayGoals();
                    break;
                case "create":
                    CreateNewGoal();
                    break;
                case "mark complete":
                    DisplayGoals();
                    MarkGoalComplete();
                    break;
                default:
                    Console.WriteLine("Invalid action. Please enter 'save', 'load', 'create', 'mark complete', or 'exit'.");
                    break;
            }
            Program.ShowGetReady();
            Console.Clear();
        }
    }

    static void CreateNewGoal()
    {
        Console.WriteLine("Enter goal type (Simple, Eternal, Checklist):");
        string type = Console.ReadLine();

        string number = goalCounter.ToString();
        goalCounter++;

        Console.WriteLine("Enter goal name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter goal description:");
        string desc = Console.ReadLine();

        if (type.ToLower() == "checklist")
        {
            Console.WriteLine("Enter goal points:");
            int point = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter required completions:");
            int requiredCompletions = int.Parse(Console.ReadLine());
            goals.Add(new ChecklistGoal(number, name, desc, point, requiredCompletions));
        }
        else if (type.ToLower() == "simple")
        {
            Console.WriteLine("Enter goal points:");
            int point = int.Parse(Console.ReadLine());

            goals.Add(CreateGoal(type, number, name, desc, point));
        }
        else
        {
            goals.Add(CreateGoal(type, number, name, desc, 0));
        }

        // Display the goals
        DisplayGoals();
    }

    static Goals CreateGoal(string type, string number, string name, string desc, int point)
    {
        switch (type.ToLower())
        {
            case "simple":
                return new SimpleGoal(number, name, desc, point);
            case "eternal":
                return new ETGoal(number, name, desc);
            default:
                throw new ArgumentException("Invalid goal type");
        }
    }

    static void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var goal in goals)
            {
                writer.WriteLine(goal.ToCsv());
                //Program.ShowGetReady(); // I don't think this is necessary
            }
        }
    }

    public static void ShowGetReady()
    {
        Program.ShowAnimation(5); // 5-second countdown
    }

    public static void ShowAnimation(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write("."); // The animation just gives "....."
            Thread.Sleep(1000);
        }
    }

    static void LoadGoals(string filename)
    {
        goals.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Goals goal = null;
                if (line.Split(',').Length == 6)
                {
                    goal = ChecklistGoal.FromCsv(line);
                }
                else if (line.Split(',').Length == 5)
                {
                    goal = SimpleGoal.FromCsv(line);
                }
                else if (line.Split(',').Length == 3)
                {
                    goal = ETGoal.FromCsv(line);
                }
                else if (line.Split(',').Length == 4)
                {
                    goal = Goals.FromCsv(line);
                }
                if (goal != null)
                {
                    goals.Add(goal);
                }
                //Program.ShowGetReady(); // I don't think this is necessary like the other one
            }
        }
    }

    static void DisplayGoals()
    {
        Console.WriteLine("Goals:");
        foreach (var goal in goals)
        {
            goal.DisplayGoal();
        }
    }

    static void MarkGoalComplete()
    {
        Console.WriteLine("Enter goal number to mark as complete:");
        string number = Console.ReadLine();

        foreach (var goal in goals)
        {
            if (goal.Number == number)
            {
                if (goal is SimpleGoal simpleGoal)
                {
                    simpleGoal.MarkComplete();
                    totalPoints += simpleGoal.Point; // Add points to total
                    Console.WriteLine("Simple goal marked as complete.");
                }
                else if (goal is ChecklistGoal checklistGoal)
                {
                    checklistGoal.IncrementCompletion();
                    if (checklistGoal.IsCompleted)
                    {
                        totalPoints += checklistGoal.Point; // Add points to total
                    }
                    Console.WriteLine("Checklist goal incremented.");
                }
                else
                {
                    Console.WriteLine("Eternal goals cannot be marked as complete. We have all of eternity to complete them.");
                }
                break;
            }
        }

        // Display the goals
        DisplayGoals();

        // Display total points
        Console.WriteLine($"Total Points: {totalPoints}");
    }
}