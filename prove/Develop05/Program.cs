using System;
using System.Collections.Generic;


class Program
{



    static void Main(string[] args)
    {   
        GoalManager gm = new GoalManager();
        //FileManager fm = new FileManager(gm.saveGoals);

        //Score attribute
        int _score = 0;
        
        string _userChoice;
        do
        {
            //Statement that keeps score
            Console.WriteLine($"\nYour score is {_score}");

            // Console.Clear();
            Console.WriteLine("\nMenu Options:\n");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");

            //Get the _userChoice
            _userChoice = Console.ReadLine();

            switch(_userChoice)
            {
                case "1":
                    gm.AddGoal();
                    break;
                case "2":
                    // simpleGoal.ListGoals();
                    // //Pause the prgram to keep the console open
                    // Console.WriteLine("Press Enter to continue.");
                    // Console.ReadLine();
                    gm.DisplayGoals();
                   // Console.ReadLine();
                    break;
                case "3":
                    gm.Save();
                    break;
                case "4":
                    gm.Load();
                    break;
                case "5":
                    Console.Write("Choose a goal to record progress on. \n");
                    gm.DisplayGoals();
                    string userInputString = Console.ReadLine();

                    //if statement to validate user's input
                    if(int.TryParse(userInputString, out int userInput)  && userInput >= 1 && userInput <= gm.saveGoals.Count)
                    {
                        Goal selectedGoal = gm.saveGoals[userInput - 1];
                         _score += gm.saveGoals[userInput - 1].RecordEvent();

                         //update selected goal in the saveGoals selected index
                         gm.saveGoals[userInput - 1] = selectedGoal;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please enter a valid number.");
                    }                   
                    break;
                case "6":
                    break;
                default:
                    Console.WriteLine("\nYour choice is not valid. Please try again.\n");
                    Thread.Sleep(4000);
                    break;
            }
        }while (_userChoice != "6");


    }


}