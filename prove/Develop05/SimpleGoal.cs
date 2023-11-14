using System;

//Derived class of goal. Goal is a Simple Goal
public class SimpleGoal : IGoal
{
    public void CreateGoal()
    {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        //test
       // Console.WriteLine($"My goal is: {name}.");
       //   Thread.Sleep(3000)
        
    }
}