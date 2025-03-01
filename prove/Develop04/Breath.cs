using System;
using System.Collections.Generic;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    { 
    }

    public void DoActivity()
    {
        DisplayIntro();
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < _duration) // Breathe in for 4 sec, Breathe out for 6 sec.
        {
            ShowCountDown("\nBreathe in.", 4);
            if ((DateTime.Now - startTime).TotalSeconds >= _duration) break;
            ShowCountDown("\nBreathe out.", 6);
            if ((DateTime.Now - startTime).TotalSeconds >= _duration) break;
        }
        DisplayWellDone();
    }
}