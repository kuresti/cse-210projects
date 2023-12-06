using System;

class Program
{
    static void Main(string[] args)
    {
        //List of Activities
        List<Activity> activities = new List<Activity>();

        //Add running, cycling and swimming activity to list

        RunningActivity running = new RunningActivity(5f, 45, "05 Dec 2022");
        activities.Add(running);

        CyclingActivity cycling = new CyclingActivity(17.5f, 120, "05 Dec 2022", true);
        activities.Add(cycling);
        
        SwimmingActivity swimming = new SwimmingActivity(55, 60, "05 Dec 2022");
        activities.Add(swimming);
        

        //foreach loop to call the GetSummaryString() method on 
        //each activity
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummaryString());
        }
    }
}