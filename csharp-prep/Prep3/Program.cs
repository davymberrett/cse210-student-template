using System;
using System.Runtime.Versioning;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int magic_number = random.Next(1, 101);
        int input_guess = 0;

        Console.WriteLine($"The magic number is: {magic_number}");
        while (input_guess != magic_number) 
        {
            Console.Write("What is your guess? ");
            input_guess = int.Parse(Console.ReadLine());
            if (input_guess < magic_number)
            {
                Console.WriteLine("Higher!");
            }
            else if (input_guess > magic_number) 
            { 
                Console.WriteLine("Lower!"); 
            }
            else 
            { 
                Console.WriteLine("Congratulations! You've guessed the magic number!");
            }
        }
    }
}