 using System;

 //Derived class of Goal. EternalGoal is a Goal.
public class EternalGoal : Goal
 {
    //Constructor of Eternal goal
      public EternalGoal(string goalName, string goalDescription, int pointValue) :base(goalName, goalDescription, pointValue)
      {}

    //Method to get the string to be saved 
    public override string GetSaveString()
    {
        return $"{GetType()}|{_goalName}|{_goalDescription}|{_pointValue}|{_isComplete}";
    }


 }