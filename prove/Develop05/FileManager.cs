using System;
using System.Collections.Generic;
using System.IO;

//Save class writes the goals to a file
public class FileManager
{
    

    //Attributes of FileManager Class
    private string _fileName;
    //savedGoals list
    private List<Goal> _saveGoals;
    public FileManager(List<Goal> saveGoals)
    {
        _saveGoals = saveGoals;
    }

    //FileManager constructor
    // public FileManager(List<Goal> saveGoals)
    // {
    //     List<Goal> saveGoals = new List<Goal>();
    // }

    //Goalmanager Instantiated
    //GoalManager gm = new();

    // public List<Goal> GetList()
    // {
    //     return saveGoals;
    // }

    //Method to write goals to file
    public void Save()
    {
        //  PUT "Enter the filename: "
        Console.Write("Please enter a filename: ");
        // List<Goal> saveGoals = gm.get_saveGoals();
    
        _fileName = Console.ReadLine();

        
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            foreach (Goal goal in _saveGoals)
            {
                outputFile.WriteLine(goal.GetSaveString());
            }
            Console.WriteLine($"Your goals are saved to {_fileName}");
        }
    }

    //Method to Load or read Goals from a file
    public void Load()
    {
        //Ask for _fileName from user
        Console.WriteLine("Please enter your filename: ");
        //Get userInput 
        _fileName = Console.ReadLine();

        //using the IO system Read lines from file
        string[] lines = System.IO.File.ReadAllLines(_fileName);
        
        //For loop to iterate through lines list and split into parts
        foreach (string line in lines)
        {
            string[] parts = line.
        }

    }

//     //  PUBLIC List<Goal> Load()
//     //      List<Goal> goals = new()
//     //      create goals based on type
//     //      ...
//     //      RETURN goals


 }