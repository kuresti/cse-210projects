using System;

public class Activity
{
    //Attributes of the Acitivy class
    protected string _activityName;
    protected string _activityDescription;
    protected int _timeInput;

    //Activity class contructor
    public Activity(string name, string description )
    {        
        _activityName = name;
        _activityDescription = description;
    }
    
    //Method to get the time that the user
    //inputs. To use in the child activities.
    public int GetTimeInput()
    {
        return _timeInput;
    }

    //Method sets the _timeInput attribute to
    //equal duration
    //public void SetTimeInput()
    //{
     //   _timeInput = duration;
    //}
    
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

}