using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start(); // Start the timer

        for (int i = 1; i <= 400000; i++)
        {
            Console.WriteLine(i);
        }

        stopwatch.Stop(); // Stop the timer
        TimeSpan elapsedTime = stopwatch.Elapsed;
        Console.WriteLine($"Counting to 400000 completed in {elapsedTime.TotalSeconds:F4} seconds.");
    }
}