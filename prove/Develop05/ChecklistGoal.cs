using System;


//Derived class of Goal that defines a Checklist Goal
 public class ChecklistGoal
 {

    //Private Attributes of ChecklistGoal
     private int _current;
     private int  _bonus;
     private int _current;

     //Constructor of the ChecklistGoal class for creating a goal

     public ChecklistGoal(string goalName, string goalDescription, int pointValue, int target, int bonus) :base(goalName, goalDescription, pointValue)
     {
          _current = 0;    
          _target = target;
          _bonus = bonus;
     }

       //Constructor of ChecklistGoal for the RecordEvent method in GoalManager
     public ChecklistGoal(string goalName, string goalDescription, int pointValue, bool isComplete, int current, int target, int bonus) :base(goalName, goalDescription, pointValue, isComplete)
     {
          _current = 0;   
          _target = target;
          _bonus = bonus;
     }


    //Override method of GetGoalString specific to ChecklistGoal
     public override string GetGoalString()
     {
         return $"{base.GetGoalString()} -- Currently completed: [{_current}/{_target}]";
     }


 }