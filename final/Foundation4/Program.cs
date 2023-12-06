using System;

class Program
{
    static void Main(string[] args)
    {
        RunningActivity running = new RunningActivity(5f, 45, "05 Dec 2022");
        Console.WriteLine(running.GetSummaryString());

        CyclingActivity cycling = new CyclingActivity(17.5f, 120, "05 Dec 2022", true);
        Console.WriteLine(cycling.GetSummaryString());

        SwimmingActivity swimming = new SwimmingActivity(55, 60, "05 Dec 2022");
        Console.WriteLine(swimming.GetSummaryString());
    }
}