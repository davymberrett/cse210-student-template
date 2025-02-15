using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var scriptures = new List<Scripture>
        {
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
            new Scripture(new Reference("D&C", 6, 36), "Look unto me in every thought; doubt not, fear not."),
            new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
        };

        var givenScriptures = new HashSet<Scripture>();

        foreach (var scripture in scriptures)
        {
            if (givenScriptures.Contains(scripture)) continue;

            givenScriptures.Add(scripture);
            
            while (!scripture.AllHidden())
            {
                ClearConsole();
                Console.WriteLine(scripture);
                Console.WriteLine("Press Enter to continue or type 'quit' to exit: ");
                var userInput = Console.ReadLine();
                if (userInput.ToLower() == "quit")
                {
                    return;
                }
                scripture.HideRandomWords();
            }

            ClearConsole();
            Console.WriteLine(scripture);
            Console.WriteLine("All words are hidden. Moving to next scripture.");
            Console.ReadLine();
        }

        Console.WriteLine("All scriptures have been given out. Program ended.");
    }

    static void ClearConsole()
    {
        Console.Clear();
    }
}
