 using System;

 //Interface of base class Goal


 public abstract class Goal
 {
     //Fields of abstract Goal class
//     //protected string _goalType;
     protected string _goalName;
     protected string _goalDescription;
     protected int _pointValue;
     protected bool _isComplete = false;



     // Constructor for initial creation by the user
     public Goal(string goalName, string goalDescription, int pointValue)
     {
         _goalName = goalName;
         _goalDescription = goalDescription;
         _pointValue = pointValue;
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


         
    //Abstract methods of Goal

    public abstract string GetGoalString();

   
    //public abstract int RecordEvent();

    public abstract string GetSaveString();


//     //Non abstract method ListGoals
    
    
 }