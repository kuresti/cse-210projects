using System;

public class ListingActivity : Activity
{
    //Attributes of the listing activity
    private List<string> _prompts;
    private List<string> _userInputs;
    private string _newPrompt;
    private string _randomPrompt;
    private string _userInput;
    private int _countedInputs;

    //Create an instance of Random
    private static Random random = new Random();

    //ListingActivity constructors
    public ListingActivity(string name, string description) :base(name, description)
    {
        //Initialize the _prompts list
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        //Initialize the _userInputs list
        _userInputs = new List<string>();
    }


    //Method to run the ListingActivity
    public void StartListingActivity()
    {
        
        //Clear console
        Console.Clear();

        //Welcome message from the base class
        DisplayWelcomeMessage("Listing Activity", "This activity will help you relfect on the good things in your life by having you list as many things as you can in a certain area.");

        //Directions
        Console.WriteLine("\nList as many responses as you can to the following prompt: ");

        //Display random prompt of a subject for the user to list
        //items relating to the prompt.
        _randomPrompt = DisplayRandomPrompt();
        Console.WriteLine($"\n**{_randomPrompt}**");

        //Prompt to begin
        Console.Write("You may begin in: "); 

        //Display CountDown for user to begin listing items
        DisplayCountDown(5);

        //Call DateTime method from base class to set
        //runtime of the Listing Activity
        DateTime endTime = ActivityRunTime();
                
        //While loop that runs the program for the amount
        //of time the user entered.
        while (DateTime.Now < endTime)
        {
            //Input user list
            Console.Write("\n> ");
            _userInput = Console.ReadLine();
            
             //Add _userInput to the _userInputs list
             _userInputs.Add(_userInput);
            
        }
        
            _countedInputs = _userInputs.Count();
            Console.WriteLine($"\nYou listed {_countedInputs} items!");
           
            DisplayEndMessage("Listing Activity");
        
    }

    //Method to display random prompts for the reflection activity
    public string DisplayRandomPrompt()
    {
        //Using .Next method, give randomizer a parameter to find the
        //max number of items in the list
        int randomNumber = random.Next(_prompts.Count);

        _newPrompt = _prompts[randomNumber];

        return _newPrompt;
    }

    //Method to count the number of items a user inputs
    public void DisplayCountedItems()
    {
       
    }



    
}