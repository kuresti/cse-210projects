using System;

//Interface of base class Goal
public abstract class Goal
{
    //Fields of abstract Goal class
    //protected string _goalType;
    protected string _goalName;
    protected string _goalDescription;
    protected int _pointValue;
   // protected List<string> _goals;

   //Abstract methods of Goal
    public abstract void CreateGoal();
    
}