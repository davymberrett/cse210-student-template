using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        int user_input = -1;
        List<int> numbers = new List<int>();
        while (user_input != 0)
        {
            Console.Write("Enter number: ");
            string userResponse = Console.ReadLine();
            user_input = int.Parse(userResponse);
            
            numbers.Add(user_input);

        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = 0;
        foreach (int numberMax in numbers)
        {
            if (numberMax > max)
            {
                max = numberMax;
            }
        }
        Console.WriteLine($"The max number was: {max}");
    }
}

