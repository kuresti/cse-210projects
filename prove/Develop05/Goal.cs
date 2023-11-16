 using System;

 //Interface of base class Goal


 public abstract class Goal
 {
     //Fields of abstract Goal class
//     //protected string _goalType;
     protected string _goalName;
     protected string _goalDescription;
     protected int _pointValue;
     protected bool _isComplete;



     // Constructor for initial creation by the user
     public Goal(string goalName, string goalDescription, int pointValue)
     {
         _goalName = goalName;
         Console.WriteLine("Initializing a goal");
         _goalDescription = goalDescription;
         _pointValue = pointValue;
         _isComplete = false;
     }
//     // Constructor for loading data from a file
//     public Goal(string goalName, string goalDescription, int pointValue, bool isComplete)
//     {
//         _goalName = goalName;
//         _goalDescription = goalDescription;
//         _pointValue = pointValue;
//         _isComplete = isComplete;
//     }

     public char GetIsCompleteChar()
    {
        if(_isComplete)
            return 'X';
        else
            return ' ';
    }


    //Virtual methods of Goal

    //default virtual GetUserGoalInput method
    public virtual void GetUserGoalInput()
    {
        // User creates a simple goal by answering prompts
        Console.Write("What is the name of your goal? ");
        goalName = Console.ReadLine();

        Console.Write("What is a short description of your goal? ");
        goalDescription = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        pointValue = int.Parse(Console.ReadLine());
    }
   
   
    //default virtual GetGoalString method
     public virtual string GetGoalString()
     {
         return $"[{GetIsCompleteChar()}] {_goalName}: {_goalDescription}";
     }

//    //Abstract methods of Goal
   
//     //public abstract int RecordEvent();

    public abstract string GetSaveString();


//     //Non abstract method ListGoals
    
    
 }