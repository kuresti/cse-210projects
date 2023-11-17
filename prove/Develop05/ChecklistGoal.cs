// using System;


// //Derived class of Goal that defines a Checklist Goal
//  public class ChecklistGoal : Goal
//  {

//     //Private Attributes of ChecklistGoal
//      private int _target;
//      private int  _bonus;
//      private int _current;

//      //Constructor of the ChecklistGoal class for creating a goal

//      public ChecklistGoal(string goalName, string goalDescription, int pointValue, int bonus, int target) : base(goalName, goalDescription, pointValue)
//      {
//           _current = 0;        
//           _bonus = bonus;
//           _target = target;
//      }

//        //Constructor of ChecklistGoal for the RecordEvent method in GoalManager
//      public ChecklistGoal(string goalName, string goalDescription, int pointValue, bool isComplete, int current, int target, int bonus) :base(goalName, goalDescription, pointValue)
//      {
//           _current = 0;   
//           _target = target;
//           _bonus = bonus;
//      }

    
//     //Override method of GetGoalString specific to ChecklistGoal
//      public override string GetGoalString()
//      {
//          return $"[ ] {_goalName} ({_goalDescription}) -- Currently completed: [{_current}/{_target}]";
//      }

//      //Override method of GetSaveString specific to ChecklistGoal
//      public override string GetSaveString()
//      {
//         return$"{GetType()}:{_goalName}, {_goalDescription}, {_pointValue} {_bonus}, {_target}, {_current}, {_isComplete}";
//      }


//  }