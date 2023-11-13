using System;

public class Menu
{
    //Attributes of Menu
    private string _userChoice;
    private bool _validChoice;


    //Constructor for the Menu Class
    public Menu()
    {

    }

    //Method to Display Menu
    public void DisplayMenu()
    {
        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");

            //Get the _userChoice
            _userChoice = Console.ReadLine();

            //Check to see if the user's choice is valid
            if (_userChoice == "1" || _userChoice == "2" || _userChoice == "3" || _userChoice == "4" || _userChoice == "5" || _userChoice == "6")
            {
                _validChoice = true;
            }
            else
            {
                Console.WriteLine("\nYour choice is not valid. Please try again.\n");
                Thread.Sleep(4000);
            }

            //Switch case of Menu options for goals
            switch(_userChoice)
            {
                case "1":
                    DisplayGoalTypesMenu();
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "6":
                    break;
            }
        }while (_userChoice != "6");
    }

    // Display Goal types Menu
    public void DisplayGoalTypesMenu()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");

        //Get _userChoice
        _userChoice = Console.ReadLine();

        //Validate _userChoice
        if (_userChoice == "1" || _userChoice == "2" || _userChoice == "3")
        {
            _validChoice = true;
        }
        else
        {
            Console.WriteLine("\nYour choice is not valid. Please try again.\n");
            Thread.Sleep(4000);
        }

        //switch case for menu choices
        switch(_userChoice)
        {
            case "1":
                break;
            case "2":
                break;
            case "3":
                break;
        }
    }
}