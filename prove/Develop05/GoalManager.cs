 using System;

public class GoalManager
 {
//     //Attributes of Menu
     private string _userChoice;
//     private int _score;
     private List<Goal> _goals = new List<Goal>();
     public List<Goal> saveGoals {get; private set;}
     //savedGoals list
    // private List<Goal> saveGoals = new List<Goal>();
//     private FileManager io = new();
    //Constructor that contains the saveGoals list
    public GoalManager()
    {
         saveGoals = new List<Goal>();
    }


     //AddGoal method to add goals to the _goals list and the saveGoals list
     public void AddGoal()
     {
        //Declaring attributes to be used to create goals
        string goalName;
        string goalDescription;
        int pointValue;
        string _userChoice;
         do
         {
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
                 

                //New instance of SimpleGoal
                 SimpleGoal simple = new(goalName, goalDescription, pointValue);

                //Adds created simple goal to lists
                 _goals.Add(simple);                 
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

                //Adds created eternal goal to lists
                _goals.Add(eternal);
                saveGoals.Add(eternal);
                 break;
             case "3":
                 break;
             case "4":
                 break;
             default:
                 Console.WriteLine("\nYour choice is not valid. Please try again.\n");
                 Thread.Sleep(4000);
                 break;
         }
         }
         while(_userChoice != "4");
     }

     public void DisplayGoals()
     {
         for (int i = 0; i < _goals.Count; i++)
         {
             Console.WriteLine($"{i + 1}. {_goals[i].GetGoalString()}");
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