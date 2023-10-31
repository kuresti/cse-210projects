using System;

public class Activity
{
    //Attributes of the Acitivy class
    protected string _activityName;
    protected string _activityDescription;
    protected int _timeInput;

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
        //End message
        Console.WriteLine("Well done!!");
        Console.WriteLine($"You have completed another {duration} seconds of the {activityName}.");
    }

}