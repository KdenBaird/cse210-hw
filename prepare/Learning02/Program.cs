using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1.company = "Del Taco";
        job1.jobTitle = "Manager";
        job1.startYear = 1706;
        job1.endYear = 2020;
        
        

        Job job2 = new Job();
        job2.company = "Google";
        job2.jobTitle = "CTO";
        job2.startYear = 1706;
        job2.endYear = 2020;
        
        Resume r = new Resume();
        r._name = "Kden Baird";
        r._jobs.Add(job1);
        r._jobs.Add(job2);
        r.Display();
    }
}