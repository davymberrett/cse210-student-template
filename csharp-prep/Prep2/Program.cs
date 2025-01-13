using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);
        
        string letter = ""; 
        string sign = GetGradeSign(percent); // Use percent to get the sign


        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "c";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter} {sign}");

        if (percent >= 70)
        {
            Console.WriteLine("You are passing!");
        }

        else
        {
            Console.WriteLine("Not passing.");
        }
    }
    public static string GetGradeSign(int grade) 
    { 
        int lastDigit = grade % 10; 
        if (lastDigit >= 7) 
            return "+"; 
        else if (lastDigit < 3) 
            return "-"; 
        else return ""; 
    }
    
}