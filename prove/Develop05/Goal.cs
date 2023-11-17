 using System;

 //Interface of base class Goal


 public abstract class Goal
 {
     //Fields of abstract Goal class
//     //protected string _goalType;
     protected string _goalName;
     protected string _goalDescription;
     protected string _goalType;
     protected string _goalDetails;
     protected int _pointValue;
     protected bool _isComplete = false;



     // Constructor for initial creation by the user
     public Goal(string goalName, string goalDescription, int pointValue)
     {
         _goalName = goalName;
         _goalDescription = goalDescription;
         _pointValue = pointValue;
     }

     //Constructor for CreateGoalFromDetails
     public Goal(string goalType, string goalDetails)
     {
        _goalType = goalType;
        _goalDetails = goalDetails;
     }
    // Constructor for loading data from a file
    public Goal(string goalName, string goalDescription, int pointValue, bool isComplete)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _pointValue = pointValue;
        _isComplete = isComplete;
    }

     public char GetIsCompleteChar()
    {
        if(_isComplete)
            return 'X';
        else
            return ' ';
    }

    //Animation Method
      public void DisplayAnimation()
    {
        List<string> celebrateStrings = new List<string>();
        celebrateStrings.Add("_)-,.*~ ~*CONGRATULATIONS! ~*~ -.,-(");
        celebrateStrings.Add("_)-,. ~*~ CONGRATULATIONS!*~ ~*-.,-(");
        
       //This piece tells the animation how long to run
       DateTime startTime = DateTime.Now;
       DateTime endTime = startTime.AddSeconds(8);

       int i = 0;
       //This loop runs the animated fish at one second
       //increments as long as the current time is less than
       //the set endTime
       while (DateTime.Now < endTime)
       {
        string celebrate = celebrateStrings[i];
        Console.Write(celebrate);
        Thread.Sleep(700);
        Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b                                    \b");
        

        i++;

        //This if statement allows the animation to restart
        //at the 0 index if the time run exceeds the fishStrings length count.
        if (i >= celebrateStrings.Count)
        {
            i = 0;
        }
       }
        //For testing
        //Console.WriteLine("Done."); 
    }


         
    //Abstract methods of Goal

    public abstract string GetGoalString();

   
    public abstract int RecordEvent();

    public abstract string GetSaveString();


//     //Non abstract method ListGoals
    
    
 }