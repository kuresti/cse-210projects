using System;
using System.Security.Cryptography.X509Certificates;


class Program
{
    static void Main(string[] args)
    {
        //Creating instances of job1 and job2
        //Using dot notation set the job variables.
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        //Call to the DisplayJobDetails method
        //job1.DisplayJobDetails();
        //job2.DisplayJobDetails();

        //New instances of the Resume class
        Resume myResume = new Resume();

        //Create instance of memberName
        myResume._memberName = "Allison Rose";

        //instantiate the jobs list and Add job1 and job2 listed 
        //above to the resume object
    
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        //Console.WriteLine(myResume._jobs[0]._jobTitle);

        //Call to display attributes from the Resume class
        myResume.DisplayResumeDetails();


        




    }
}