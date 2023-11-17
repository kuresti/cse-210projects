 using System;

 //Derived class of Goal. EternalGoal is a Goal.
public class EternalGoal : Goal
 {
    //Constructor of Eternal goal
      public EternalGoal(string goalName, string goalDescription, int pointValue) :base(goalName, goalDescription, pointValue)
      {}

      //Constructor of EternalGoal for the load method
     public EternalGoal(string goalName, string goalDescription, int pointValue, bool isComplete) :base(goalName, goalDescription, pointValue, isComplete)
     {}

    
    //Method to get the string to display
    public override string GetGoalString()
      {
            return $"[ ] {_goalName} ({_goalDescription})";
      }

    //Method to get the string to be saved 
    public override string GetSaveString()
    {
        return $"{GetType()}:{_goalName}|{_goalDescription}|{_pointValue}|{_isComplete}";
    }

    //RecordEvent method implemented from abstract method of Goal class
      public override int RecordEvent()
      {
          
          Console.WriteLine($"Congratulations! You have earned {_pointValue}");
          DisplayAnimation();
          
          return _pointValue;

      }


 }