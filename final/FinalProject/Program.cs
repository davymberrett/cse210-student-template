using System;

class Program 
{
    static University university = new University("Example University", "Example City");
    
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear(); // Clear the console screen
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Find by ID");
            Console.WriteLine("2. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    FindByID();
                    break;
                case "2":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void FindByID()
    {
        Console.WriteLine("Enter ID:");
        string id = Console.ReadLine();
        university.FindByID(id);
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine(); // Wait for the user to press Enter
    }
}