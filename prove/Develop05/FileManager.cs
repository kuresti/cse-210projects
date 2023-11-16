using System;
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

        //  filename = GET
        _fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            foreach (Goal goal in _saveGoals)
            {
                outputFile.WriteLine(goal.GetSaveString());
            }
        }
    }

//     //  PUBLIC List<Goal> Load()
//     //      List<Goal> goals = new()
//     //      create goals based on type
//     //      ...
//     //      RETURN goals


 }