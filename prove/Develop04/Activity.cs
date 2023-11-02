using System;

public class Activity
{
    //Attributes of the Acitivy class
    protected string _activityName;
    protected string _activityDescription;
    protected int _timeInput;
    protected int _countDownTime;

    //Activity class contructor for welcome message
    public Activity(string name, string description )
    {        
        _activityName = name;
        _activityDescription = description;
    }

    //Activity class constructor for end message
    public Activity(string name)
    {
        _activityName = name;
    }

    //Activity class constructor for CountDown display
    public Activity(int seconds)
    {
        _countDownTime = seconds;
    }


    
    //Method to get the time that the user
    //inputs. To use in the child activities.
    public int GetTimeInput()
    {
        return _timeInput;
    }

        
    //Method to Display the Welcome message for
    //all three activities
    public void DisplayWelcomeMessage(string activityName, string activityDescription)
    {
        //Welcome message
        Console.WriteLine($"Welcome to the {activityName}.");

        //Activity description
        Console.WriteLine($"\nThis activity {activityDescription}.");

        //User time Prompt
        Console.WriteLine("\nHow long, in seconds, would you like for your session? ");
        _timeInput = int.Parse(Console.ReadLine());

    } 

    //End of activity method
    public void DisplayEndMessage(string activityName)
    {
        //Call GetTimeInput
        int duration = GetTimeInput();

        //
        //End message
        Console.WriteLine("Well done!!");

        Console.WriteLine($"You have completed another {duration} seconds of the {activityName}.");
    }

    //Animation Method that has the program pause while showing an animation
    // ><(((('> , ><(((('<
    public void DisplayAnimation()
    {
        List<string> fishStrings = new List<string>();
        fishStrings.Add("~~~~~><(((('>");
        fishStrings.Add("~~~~><(((('<");
        
       //This piece tells the animation how long to run
       DateTime startTime = DateTime.Now;
       DateTime endTime = startTime.AddSeconds(5);

       int i = 0;
       //This loop runs the animated fish at one second
       //increments as long as the current time is less than
       //the set endTime
       while (DateTime.Now < endTime)
       {
        string fish = fishStrings[i];
        Console.Write(fish);
        Thread.Sleep(1000);
        Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b  \b");

        i++;

        //This if statement allows the animation to restart
        //at the 0 index if the time run exceeds the fishStrings length count.
        if (i >= fishStrings.Count)
        {
            i = 0;
        }
       }
        //For testing
        //Console.WriteLine("Done."); 
    }

    //This method will display a countdown
    public void DisplayCountDown(int seconds)
    {
        for (; seconds > 0; seconds--)
        {
            Console.Write(seconds);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}