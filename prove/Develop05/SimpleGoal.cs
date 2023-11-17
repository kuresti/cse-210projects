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

      
      //GetGoalString method implemented from abstract method in Goal class
      public override string GetGoalString()
      {
            return $"[ ] {_goalName} ({_goalDescription})";
      }

      //GetSave string implemented from abstract method in Goal class
      public override string GetSaveString()
      {
            return $"{GetType()}:{_goalName}|{_goalDescription}|{_pointValue}|{_isComplete}";
      }
 }