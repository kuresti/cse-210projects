using System;

public class ReflectionActivity : Activity
{
    //Attributes of ReflectionActivity
    private string _randomPrompt;

    private string _newPrompt;
    private string _randomQuestion;
    private string _newQuestion;

    //Empty list of used questions
    private List<string> _usedQuestions = new List<string>();

    //Lists to hold prompts and questions that will be initilized
    //in the constructor
    private List<string> _prompts;
    private List<string> _questions;

    //Create an instance of a randomizer
    private static Random random = new Random();     

    //Constructor for the ReflectionActivity
    public ReflectionActivity(string name, string description) : base(name, description)
    {    
        //Initialize _prompts list
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need",
            "Think of a time when you did something truly selfless"
        };

        //Initialize _questions list
        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };     
    }

    public void StartReflection()
    {
        //Welcome Message from the base class: Activity
        DisplayWelcomeMessage("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize thepower you have and how you can use it in other aspects of your life.");

        //This piece tells how long to run the reflectionvity
        DateTime endTime = ActivityRunTime();

        //Call DisplayRandomPrompt
         _randomPrompt = DisplayRandomPrompt();
         Console.WriteLine($"\n**{_randomPrompt}**");

        //Have the user press enter when they have something 
        //in mind
        Console.WriteLine("\nWhen you have something in mind, press Enter to continue."); 
        Console.ReadLine();

        //Instruction message for continuing on
        Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience.");
        Console.Write("\nYou may begin in:");
        DisplayCountDown(5); 

        //Inside the while loop random questions will be shown
        //for 8 seconds and then change until runTime is done.
         while (DateTime.Now < endTime)
         {
            for (int i = 0; i < 8; i++)
            {
            //Call DisplayRandomQuestion
            _randomQuestion = DisplayRandomQuestion();
            Console.WriteLine($"\n{_randomQuestion}"); 
             //Call Animation method
            DisplayAnimation();
       
            }

         }
         DisplayEndMessage("Reflection Activity");        
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

    //Method to display random questions to ponder for the reflection activity
    public string DisplayRandomQuestion()
    {
        
        if (_questions.Count == 0)
        {
            //When all questions are used, reset the list
            _questions.AddRange(_usedQuestions);
            _usedQuestions.Clear();
        }

        //Using .Next method, give randomizer a parameter to find the
        //max number of items in the question list
        int index = random.Next(_questions.Count);

        _newQuestion = _questions[index];

        //Move the used question from the _questions list to _usedQuestions list
        _questions.RemoveAt(index);
        _usedQuestions.Add(_newQuestion);

        return _newQuestion;
    }






}