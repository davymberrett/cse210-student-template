using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    private List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries found.");
        }
        else
        {
            foreach (Entry entry in entries)
            {
                Console.WriteLine(entry);
            }
        }
    }

    public void SaveToFile(string filename)
    {
        try
        {
            using (StreamWriter file = new StreamWriter(filename))
            {
                foreach (Entry entry in entries)
                {
                    file.WriteLine(entry);
                }
            }
            Console.WriteLine($"Journal saved to {filename}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal: {ex.Message}");
        }
    }

    public void LoadFromFile(string filename)
    {
        entries = new List<Entry>();

        try
        {
            using (StreamReader file = new StreamReader(filename))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    string date = line.Split(": ")[1];
                    string prompt = file.ReadLine().Split(": ")[1];
                    string response = file.ReadLine().Split(": ")[1];
                    entries.Add(new Entry(prompt, response, date));

                    // Skip empty line if present
                    file.ReadLine();
                }
            }
            Console.WriteLine($"Journal loaded from {filename}");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"File '{filename}' not found.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal: {ex.Message}");
        }
    }
}