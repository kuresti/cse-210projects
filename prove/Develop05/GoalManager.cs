 using System;
 using System.Collections.Generic;
 using System.IO;

public class GoalManager
 {
     //Attributes of Menu
     private string _userChoice;
     private string _fileName;

     //private int _score;
     //private List<Goal> _goals = new List<Goal>();
     public List<Goal> saveGoals {get; private set;}
     //savedGoals list
    // private List<Goal> saveGoals = new List<Goal>();
//     private FileManager io = new();
    //Constructor that contains the saveGoals list
    public GoalManager()
    {
         saveGoals = new List<Goal>();
    }

    //Creating instance of SimpleGoal
    //SimpleGoal simple = new SimpleGoal();

     //AddGoal method to add goals to the _goals list and the saveGoals list
     public void AddGoal()
     {
        //Declaring attributes to be used to create goals
        string goalName;
        string goalDescription;
        int pointValue;
        int bonus;
        int target;
         //string _userChoice;
        // int bonus;
        // int target;
        // do
         //{
//         Console.Clear();
         Console.WriteLine("The types of Goals are:");
         Console.WriteLine("1. Simple Goal");
         Console.WriteLine("2. Eternal Goal");
         Console.WriteLine("3. Checklist Goal");
         Console.WriteLine("4. Return to Main menu");
         Console.Write("Which type of goal would you like to create? ");

         //Get _userChoice
         _userChoice = Console.ReadLine();

         //switch case for menu choice
         switch (_userChoice)
         {
             case "1":
                 // User creates a simple goal by answering prompts
                Console.Write("What is the name of your goal? ");
                goalName = Console.ReadLine();

                Console.Write("What is a short description of your goal? ");
                goalDescription = Console.ReadLine();

                Console.Write("What is the amount of points associated with this goal? ");
                pointValue = int.Parse(Console.ReadLine());

                //New instance of SimpleGoal
                 SimpleGoal simple = new(goalName, goalDescription, pointValue);
                
                //Adds created simple goal to list                 
                saveGoals.Add(simple);
                

                 break;
             case "2":
                //User creates an eternal goal by answering prompts
                Console.Write("What is the name of your goal? ");
                goalName = Console.ReadLine();

                Console.Write("What is a short description of your goal? " );
                goalDescription = Console.ReadLine();

                Console.Write("What is the amount of points associated with this goal? ");
                pointValue = int.Parse(Console.ReadLine());

                //New instance of Eternal goal with parameters
                EternalGoal eternal = new(goalName, goalDescription, pointValue);

                //Adds created eternal goal to list
                saveGoals.Add(eternal);
                 break;
             case "3":

                // User creates a simple goal by answering prompts
                Console.Write("What is the name of your goal? ");
                goalName = Console.ReadLine();

                Console.Write("What is a short description of your goal? ");
                goalDescription = Console.ReadLine();

                Console.Write("What is the amount of points associated with this goal? ");
                pointValue = int.Parse(Console.ReadLine());

                Console.Write("What is the amount of points associate with the bonus for completing this goal? ");
                bonus = int.Parse(Console.ReadLine()); 

                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                target = int.Parse(Console.ReadLine());
                //New instance of ChecklistGoal with parameters
                ChecklistGoal checklist = new(goalName, goalDescription, pointValue, bonus, target);

                //Add created Checklist goal to list                        
                saveGoals.Add(checklist);
                 break;
             default:
                 Console.WriteLine("\nYour choice is not valid. Please try again.\n");
                 Thread.Sleep(4000);
                 break;
        }
         //}
         //while(_userChoice != "4");
     }

     public void DisplayGoals()
     {
         for (int i = 0; i < saveGoals.Count; i++)
         {
             Console.WriteLine($"{i + 1}. {saveGoals[i].GetGoalString()}");
         } 
     }

     public void Save()
    {
        //  PUT "Enter the filename: "
        Console.Write("Please enter a filename: ");
        // List<Goal> saveGoals = gm.get_saveGoals();
    
        _fileName = Console.ReadLine();

        
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            foreach (Goal goal in saveGoals)
            {
                outputFile.WriteLine(goal.GetSaveString());
            }
            Console.WriteLine($"Your goals are saved to {_fileName}");
        }
    }

    //Method to Load or read Goals from a file
    public List<Goal> Load()
    {
        //Prompt for filename from the user
        Console.Write("Please enter your filename: ");

        //Get filename from userInput
        _fileName = Console.ReadLine();

        //Using the IO system, read lines from the file
        string[] lines = System.IO.File.ReadAllLines(_fileName);

        //For loop to iterate thorugh the lines list
        foreach (string line in lines)
        {
            //Split the line into parts based on the colon
            string[] colonParts = line.Split(":");
            string goalType = colonParts[0];
            string goalDetails = colonParts[1];

            //New instance of Goal
            Goal newGoal = CreateGoalFromDetails(goalType, goalDetails);

            //Add the new goal to the existing list
            saveGoals.Add(newGoal);
        } 
        //Return list
        return saveGoals;
    }
    
    //Method to create a goal from the Details
    private Goal CreateGoalFromDetails(string goalType, string goalDetails)
    {
        
        string goalName;
        string goalDescription;
        int bonus;
        int pointValue;
        int target;
        int current;
        bool isComplete;
        switch(goalType)
        {
            case "SimpleGoal":
                 string[] simpleDetailsParts = goalDetails.Split("|");
                 goalName = simpleDetailsParts[0];
                 goalDescription = simpleDetailsParts[1];
                 pointValue = int.Parse(simpleDetailsParts[2]);
                 isComplete = bool.Parse(simpleDetailsParts[3]);

                //New instance of SimpleGoal
                return new SimpleGoal(goalName, goalDescription, pointValue, isComplete);

            case "EternalGoal":
                 string[] eternalDetailsParts = goalDetails.Split("|");
                 goalName = eternalDetailsParts[0];
                 goalDescription = eternalDetailsParts[1];
                 pointValue = int.Parse(eternalDetailsParts[2]);
                 isComplete = bool.Parse(eternalDetailsParts[3]);

                //New instance of EternalGoal
                return new EternalGoal(goalName, goalDescription, pointValue, isComplete);

            case "ChecklistGoal":
                string[] checklistDetailParts = goalDetails.Split("|");
                goalName = checklistDetailParts[0];
                goalDescription = checklistDetailParts[1];
                pointValue = int.Parse(checklistDetailParts[2]);
                bonus = int.Parse(checklistDetailParts[3]);
                target = int.Parse(checklistDetailParts[4]);
                current = int.Parse(checklistDetailParts[5]);
                isComplete = bool.Parse(checklistDetailParts[6]);

                //New instance of  ChecklistGoal
                return new ChecklistGoal(goalName, goalDescription, pointValue, isComplete, target, current, bonus);


                //default
                default:
                    throw new ArgumentException($"Uknown goalType: {goalType}");
                

        }
        
    }

   

       

//     //  PUBLIC RecordEvent()        NOTE: Select the goal to execute the .RecordEvent()
//     //      DisplayGoals()
//     //      PUT "Choose a goal to complete: "
//     //      choice = GET
//     //      _score += _goals[choice - 1].RecordEvent()


//     //  PUBLIC Save()
//     //      io.Save(_goals)

//     //  PUBLIC Load()
//     //      _goals = io.Load()
        

 }