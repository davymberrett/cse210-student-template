using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();
        Console.Write("What is your name? ");
        string userName = Console.ReadLine();
        DisplayPersonalMessage(userName);
    }
    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    void DisplayPersonalMessage(string userName)
    {
        Console.WriteLine($"Hello {userName}");
    }