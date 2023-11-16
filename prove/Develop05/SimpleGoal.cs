 using System;

 //Derived class of goal. Goal is a Simple Goal
 public class SimpleGoal : Goal
 {
     //Constructor of SimpleGoal to be instantiated in the FileManager class
     public SimpleGoal(string goalName, string goalDescription, int pointValue) :base(goalName, goalDescription, pointValue)
     {}


//     // public override int RecordEvent()
//     // {
//     //     //  isComplete -> True
//     //     //  PUT "Congrates..."
//     //     //  RETURN _points
//     // }
      //GetGoalString method inherited from abstract Goal
    public override string GetSaveString()
    {
        return $"{GetType()}|{_goalName}|{_goalDescription}|{_pointValue}|{_isComplete}";
    }
 }