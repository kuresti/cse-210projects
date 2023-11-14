using System;

//Derived class of goal. Goal is a Simple Goal
public class SimpleGoal : Goal
{
    //CreateGoal method inherited and implemented from the IGoal interface
    public override void CreateGoal()
    {
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();

        Console.Write("What is a short description of your goal? ");
        _goalDescription = Console.ReadLine();
        
        Console.Write("What is the amount of points associated with this goal? ");
        _pointValue = int.Parse(Console.ReadLine());

        //test
        Console.WriteLine($"My goal is: {_goalName}. {_goalDescription} {_pointValue}");
        Thread.Sleep(3000);
        
    }
}