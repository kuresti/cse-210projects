 using System;

 //Derived class of goal. Goal is a Simple Goal
 public class SimpleGoal : Goal
 {

      //Constructor of SimpleGoal to be instantiated in the FileManager class
     public SimpleGoal(string goalName, string goalDescription, int pointValue) :base(goalName, goalDescription, pointValue)
     {}

     //Constructo of SimpleGoal for the load method
     public SimpleGoal(string goalName, string goalDescription, int pointValue, bool isComplete) :base(goalName, goalDescription, pointValue, isComplete)
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
            return $"[{GetIsCompleteChar()}] {_goalName} ({_goalDescription})";
      }

      //GetSave string implemented from abstract method in Goal class
      public override string GetSaveString()
      {
           
            return $"{GetType()}:{_goalName}|{_goalDescription}|{_pointValue}|{_isComplete}";
      }

      //RecordEvent method implemented from abstract method of Goal class
      public override int RecordEvent()
      {
          _isComplete = true;
          Console.WriteLine($"Congratulations! You have earned {_pointValue}");
          DisplayAnimation();
          
          return _pointValue;

      }

      
 }