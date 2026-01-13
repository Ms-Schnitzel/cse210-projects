using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Resumes Project.");
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2001;
        job1._endYear = 2015;

        Job job2 = new Job();
        job2._company = "Amazon";
        job2._jobTitle = "Marketing Lead";
        job2._startYear = 2010;
        job2._endYear = 2025;

        // job1.Display();
        // job2.Display();

        Resume resumes = new Resume();
        resumes._name = "Alice Wonderland";
        resumes._jobs.Add(job1);
        resumes._jobs.Add(job2);

        // resumes._jobs[0].Display();
        resumes.Display();



    }
}