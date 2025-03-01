using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string> //List of random queshtons
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a \ncertain area.")
    {
    }

    public void DoActivity()
    {
        DisplayIntro();
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine(prompt);
        ShowCountDown("\nStart listing in.", 5);
        DateTime startTime = DateTime.Now;
        List<string> items = new List<string>();
        while ((DateTime.Now - startTime).TotalSeconds < _duration) //Won't move on intell the user finishes there input.
        {
            Console.Write("Enter an item: ");
            string item = Console.ReadLine();
            items.Add(item);
        }
        Console.WriteLine($"You listed {items.Count} items.");
        DisplayWellDone();
    }
}