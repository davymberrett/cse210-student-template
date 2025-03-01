using System;
using System.Collections.Generic;
using System.Threading;

public class Activity
{
    protected string _name;
    protected string _desc;
    protected int _duration;

    public Activity(string name, string desc) // Sets the activity name and the totle time
    {
        _name = name;
        _desc = desc;
        _duration = 0;
    }

    public void DisplayIntro()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine(_desc);
        PromptDuration();
        Console.WriteLine("Get ready to begin.");
        ShowGetReady();
    }

    public void PromptDuration()
    {
        while (true)
        {
            Console.Write("Enter the duration in seconds: ");
            if (int.TryParse(Console.ReadLine(), out _duration) && _duration > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Please enter a positive integer.");
            }
        }
    }

    public void ShowGetReady()
    {
        ShowAnimation(5); // 5-second countdown
    }

    public void ShowAnimation(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write("."); // The animation just gives "....."
            Thread.Sleep(1000);
        }
    }

    public void ShowCountDown(string message, int seconds) // tells the user how long the activity was
    {
        Console.WriteLine(message);
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
    }

    public void DisplayWellDone() // finish message
    {
        Console.WriteLine("Well done!");
        Thread.Sleep(2000);
        Console.WriteLine($"You have completed the {_name} activity for {_duration} seconds.");
        Thread.Sleep(2000);
    }
}