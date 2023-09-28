using System;
using System.Reflection.Metadata.Ecma335;

//A template for the category of things known as Resume. The
//responsibility of Resume is to hold and display job information
//and personal information for member
public class Resume
{
    //attributes or variables for person or member
    public string _memberName;

    //Create empty list for Jobs
     //Create empty list for numbers
    public List<Job> _jobs = new List<Job>();
    

    //Constructor for the Resume class
    public Resume()
    {
    }

    //Method to display the details of Resume
   public void DisplayResumeDetails()
   {
    Console.WriteLine($"Name: {_memberName}");
    Console.WriteLine("Jobs:");

    //foreach Loop to iterate the _jobs list
    foreach(Job job in _jobs)
    {
        job.DisplayJobDetails();
    }

   }

}