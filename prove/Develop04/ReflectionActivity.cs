using System;

/*public class ReflectionActivity : Activity
{
    //Attributes of ReflectionActivity
    private string _randomPrompt;
    private string _randomQuestion;

    //List that holds the prompts for reflection
    List<string> prompts = new List<string>();
    prompts.Add("Think of a time when you stood up for someone else.");
    prompts.Add("Think of a time when you did something really difficult.");
    prompts.Add("Think of a time when you helped someon in need");
    prompts.Add("Think of a time when you did something truly selfless");

    //List that holds questions to reflect on the previous prompt experience
    List<string> questions = new List<string>();
    questions.Add("Why was this experience meaningful to you?");
    questions.Add("Have you ever done anything like this before?");
    questions.Add("How did you get started?");
    questions.Add("How did you feel when it was complete?");
    questions.Add("What made this time different than other times when you were not as successful?");
    questions.Add("What is your favorite thing about this experience?");
    questions.Add("What could you learn from this experience that applies to other situations?");
    questions.Add("What did you learn about yourself through this experience?");
    quesitons.Add("How can you keep this experience in mind in the future?");

    //Constructor for the ReflectionActivity
    public ReflectionActivity(string name, string description) : base(name, description)
    {           
    }

    public void StartReflection()
    {
        //Welcome Message from the base class: Activity
        DisplayWelcomeMessage("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize thepower you have and how you can use it in other aspects of your life.");

        
    }

}