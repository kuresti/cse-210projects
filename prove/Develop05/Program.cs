using System;
using System.Collections.Generic;


class Program
{



    static void Main(string[] args)
    {   
        GoalManager gm = new();
        FileManager fm = new FileManager(gm.saveGoals);
        
        string _userChoice;
        do
        {
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
                    fm.Save();
                    break;
                case "4":
                    break;
                case "5":
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