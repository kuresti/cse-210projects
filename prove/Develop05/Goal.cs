using System;

//Interface of base class Goal
public abstract class Goal
{
    //Fields of abstract Goal class
    //protected string _goalType;
    protected string _goalName;
    protected string _goalDescription;
    protected int _pointValue;
    protected List<string> _goals = new List<string>();  
    protected string _goalType;
    protected string _createdGoal;
    protected string _goalList;

    //constructor of Goal to initialize the _goals list
    public Goal()
    {
        _goals = new List<string>();
    }


   //Abstract methods of Goal
    public abstract void CreateGoal();

    //Non abstract method ListGoals
    public void ListGoals()
    {
        
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i]}");
        }
            
    }
    
}