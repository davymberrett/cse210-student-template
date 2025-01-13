using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();
        string userNameImput = PersonalName();
        int numberImput = PersonalNumber();
        int squarenumber = SquareYourNumber(numberImput);

        DisplayAnswer(userNameImput, squarenumber);
        
    }
    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PersonalName()
    {
        Console.Write("What is your name? ");
        string userName = Console.ReadLine();

        return userName;
    }
    static int PersonalNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }
    static int SquareYourNumber(int UserNumber)
    {
        int square = UserNumber * UserNumber;
        return square;
    }
    static void DisplayAnswer(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}