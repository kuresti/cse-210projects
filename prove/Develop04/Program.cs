using System;

class Program
{
    static void Main(string[] args)
    {
        //---TESTING---
        //Calling the Activity class to test the GetTimeInput method
        Activity newActivity = new Activity("Breathing", "will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

        newActivity.DisplayWelcomeMessage("Breathing", "will help you relax by walking you through breathing in and out slowly. Clear your mind and focus.");

        newActivity.DisplayEndMessage("Breathing");

        //Calling Menu class and DisplayMenu method
        Menu newMenu = new Menu();
        newMenu.DisplayMenu();

        


    }
}