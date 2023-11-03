using System;

//Menu class for the mindfulness program
public class Menu
{
    //Attributes of the menu class
    private string _userChoice;

    private bool _validChoice = false;

    //Constructor for the menu class
    public Menu()
    {
    }

    //Initializing the Breathing Activity instance
    BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing." );
    
    //Initialize the Reflection Activity instance
    ReflectionActivity reflectionActivity = new ReflectionActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    
    //Method to display a menu from which a 
    //user can make a choice
    public void DisplayMenu()
    {
        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("\n1. Start breathing activity");
            Console.WriteLine("2. Start reflection activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");

            //Get the user's choice
            _userChoice = Console.ReadLine();

            //checks to see if user's choice is a valid option
            if (_userChoice == "1" || _userChoice == "2" || _userChoice == "3" || _userChoice == "4")
            {
                _validChoice = true;
            }
            else
            {
                Console.WriteLine("\nYour choice is not valid. Please try again.\n");
            }

            //A switch case of menu options that starts
            //the activity that the user chooses
            switch(_userChoice)
            {
                case "1":
                    breathingActivity.StartBreathing();
                    break;
                case "2":
                    reflectionActivity.StartReflection();
                    break;
                case "3":
                    break;
                case "4":
                    break;
            }

        }while(_userChoice != "4");
    }

}