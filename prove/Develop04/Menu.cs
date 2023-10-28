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

    //Method to display a menu from which a 
    //user can make a choice
    public void DisplayMenu()
    {
        do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
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
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
            }

        }while(_userChoice != "4");
    }

}