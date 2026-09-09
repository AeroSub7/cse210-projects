using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Apple";
        job1._jobTitle = "Line Cook";
        job1._startYear = 1980;
        job1._endYear = 2000;
        Job job2 = new Job();
        job2._company = "Microsoft";
        job2._jobTitle = "Baker";
        job2._startYear = 2002;
        job2._endYear = 2005;

        Resume resume = new Resume();
        resume._name = "Tom Holland";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume.DisplayResume();

    }
}