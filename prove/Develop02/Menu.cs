using System;
using System.Collections.Generic;

class Menu
{
    private Journal journal;
    private PromptMan promptMan;

    public Menu(Journal journal, PromptMan promptMan)
    {
        this.journal = journal;
        this.promptMan = promptMan;
    }

    public void DisplayMenu()
    {
        while (true)
        {
            Console.WriteLine("\nJournal Menu");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.WriteLine("6. Calculatore");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteEntry();
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    SaveJournal();
                    break;
                case "4":
                    LoadJournal();
                    break;
                case "5":
                    return;
                case "6":
                    Calculator();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    private void WriteEntry()
    {
        string prompt = promptMan.GetRandomPrompt();
        Console.WriteLine(prompt);
        string response = Console.ReadLine();
        string date = DateTime.Today.ToString("yyyy-MM-dd");

        Entry entry = new Entry(prompt, response, date);
        journal.AddEntry(entry);
    }

    private void Calculator()
    {
       Console.Write("What is the first number you want to add together? ");
       int FirstNumber = int.Parse(Console.ReadLine());
       Console.Write("What is the second number you want to add together? ");
       int SecondNumber = int.Parse(Console.ReadLine());
       int NumberAnswer = FirstNumber + SecondNumber;
       Console.Write($"{NumberAnswer}");

    }

    private void SaveJournal()
    {
        Console.Write("Enter the filename to save the journal: ");
        string filename = Console.ReadLine();
        journal.SaveToFile(filename);
    }

    private void LoadJournal()
    {
        Console.Write("Enter the filename to load the journal: ");
        string filename = Console.ReadLine();
        journal.LoadFromFile(filename);
    }
}
