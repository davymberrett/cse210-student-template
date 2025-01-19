using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Computer scientist";
        job1._company = "intel";
        job1._startYear = 2007;
        job1._endYear = 2016;

        Job job2 = new Job();
        job2._jobTitle = "E.E.";
        job2._company = "Rocky mountein power";
        job2._startYear = 2017;
        job2._endYear = 2023;

        Resume worker1 = new Resume();
        worker1._name = "Bob Brown";

        worker1._jobs.Add(job1);
        worker1._jobs.Add(job2);

        worker1.Display();

    }
}