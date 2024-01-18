using System;
using Project;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobtittle = "Sofware Engineer";
        job1._company = "Accel Congo";
        job1._startdate = 2015;
        job1._enddate = 2023;
        
        Console.WriteLine($"{job1._jobtittle} ({job1._company}) {job1._startdate}-{job1._enddate} ");

        Job job2 = new Job();
        job2._company = "Chief Technology Officer";
        job2._jobtittle = "CALI";
        job2._startdate = 2019;
        job2._enddate = 2024;

        Resume myResume = new Resume();
        myResume._name = "Allison Rose";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}