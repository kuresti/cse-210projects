using System;

public class BreathingActivity : Activity
{
    //Attributes of BreathingActivity
    private string _breathIn = "Breathe in...";
    private string _breathOut = "Breathe out...";

    //Constructor of BreathingActivity
    public BreathingActivity(string name, string description) : base(name, description)
    {           
    }

    public void StartBreathing()
    {
        //Welcome message
        DisplayWelcomeMessage("Breathing Activity","This activity will help you relax by walking you thorugh breathing in and out slowly. Clear your mind and focus on your breathing.");
        
        //Created a string of breathe in and breath out
        List<string> breaths = new List<string>();
        breaths.Add(_breathIn);
        breaths.Add(_breathOut);

        //This piece tells how long to run the breathing activity
        DateTime endTime = ActivityRunTime();

       int i = 0;
       //This loop will rund the breathing activity as long as
       //The current time is less than the endTime
       while (DateTime.Now < endTime)
       {
        string breath = breaths[i];
        Console.WriteLine($"\n{breath}"); 
        

        //This will display the countdown for breathing in
        if (breath == _breathIn)
        {
           DisplayCountDown(4); //breathe in for 4 seconds
        }
        else if (breath == _breathOut)
        {
            DisplayCountDown(6); //breathe out for 6 seconds
        }

        //In order to alternate between breathing in and breathing out
        i = (i + 1) % breaths.Count;

       }

       DisplayEndMessage("Breathing Activity");
    }

}