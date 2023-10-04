using System;

//A template for the category of things known as Menu
public class PromptGenerator
{
    // Attribute of Prompt Generoator

    //Daily prompt
    public string _dailyPrompt;
    //List that holds 30 journal prompts
    
    List<string> _prompts = new List<string> {"What was your favorite thing about today and why?", "What is a problem faced today and how did you solve it?", 
    "Tell about an act of service that you performed or someone did for you...", "Tell about something that you learned today...", 
    "Tell about one person that you are grateful for today and why you are grateful for them...",
    "What would you change about today? Why would you change it? How would you change it?",
    "What is your favorite childhood memory?", "If you could meet anyone in the world, who would it me and what would you ask them?",
    "Tell about an accomplishment of yours, what steps did you take? What did you learn along the way?",
    "Tell about what brings joy in your life...", "Tell about what brings peace in your life...",
    "Who is your hero and what attributes make them your hero?", "What can I do to bring more joy to others?",
    "What was surprising about your day?", "Tell about a favorite memory of your mother or mother figure in your life...",
    "Tell about a favorite memor of your father or father figure in your life...", 
    "What is an attribute you would like to work on? What will you do to gain that attribute?",
    "What is your favorite scripture passage and why?", "Is gaining knowledge important to you? Why or why not?",
    "What are 3 goals you would like to reach? List a plan to reach them.", "What was the hardest part of your day?",
    "What is something you fear? How can you overcome it?", 
    "What is something you would like to learn? what are steps you can take to learn about that thing?",
    "What are some things I can do to be a kinder person?", "What super power would you like to have and why?",
    "What would you like your children to know about who you are right now?", "What are you grateful for today?",
    "Who are you grateful for today?", "Tell about who your friends are and what you like about them?",
    "What qualities does a good friend have?"};

    public PromptGenerator()
    {
    }

    //Method to display daily prompt   
    public void DisplayPrompt()
    {
        //Create an instance of a randomizer
        Random _dailyPrompt = new Random();
        
        //Using .Next method, give randomizer a parameter to find the
        //max number of items in the list
        int randomNumber = _dailyPrompt.Next(_prompts.Count);

        //Display a random prompt fro the prompts list
        Console.WriteLine((string)_prompts[randomNumber]);
    }

}