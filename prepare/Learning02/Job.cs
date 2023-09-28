
using System;

//A template for the category of things known as Job. The
//responsibility of Job is to hold and display Job information
public class Job
{
    //attributes or variables relating to Job
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear = 0;                                                                                                                                        
    public int _endYear = 0;

    //Constructor for Job
    public Job()
    {
    }

    //A method that display's the Job Details in the format
    //of Job Title, company, startYear to endYear
    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
    
    
}