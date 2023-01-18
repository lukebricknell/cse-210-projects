using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Lumaza Labs";
        job1._jobTitle = "Marketer";
        job1._startYear = 2014;
        job1._endYear = 2020; 

        job1.JobDescription();

        Job job2 = new Job();
        job2._company = "Microsoft";
        job2._jobTitle = "Developer";
        job2._startYear = 2010;
        job2._endYear = 2016; 
        
        job2.JobDescription();

        Resume myResume = new Resume();

        myResume._name = "Luke";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();


    }
}
