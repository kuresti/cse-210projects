using System;
using System.Collections;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

public class Journal
{
    //attributes of Journal class

   public string _location;
   public string _locationPrompt;
   public string _response;
   public string _prompt;
   public string _todayDate;
  
    public string _fileName;
   public string _journalFile;

   
   public string _entry;


     public List<string> entry/*entries*/ = new List<string>();

    //New instance of PromptGenerator Class
    PromptGenerator newPrompt = new PromptGenerator();
    
        

    public void AddEntry()
    {
         //Date time object
         DateTime date1 = DateTime.Now;
        _todayDate = "\nDate: " + date1;

        //print date to console
         Console.WriteLine($"\n{_todayDate}");

         //Prompts user to enter their location and prints to console
         _locationPrompt = "What is your location? ";
         Console.Write(_locationPrompt);
        _location = Console.ReadLine();

        //Grabs a journal prompt from prompt generator and prints to console
         _prompt = newPrompt.DisplayPrompt();
         Console.Write($"{_prompt}\n");

        //Gets and reads the user's response to the prompt
        _response = Console.ReadLine();

        //Adds all of the attributes of the AddEntry method and 
        //writes them to the entry list
        entry.Add(_todayDate);
        entry.Add(_locationPrompt);
        entry.Add(_location);
        entry.Add(_prompt);
        entry.Add(_response);
    }

    //Behaviors of Journal class
    public void LoadJournal()//needs a parameter
    {
        
            Console.Write("Please enter the file name (MyJournal.txt): ");//take this out
            Console.ReadLine();
            Console.WriteLine("Loading file....");

            //if statement to check if the MyJournal.txt exists
            //if it doesn't exist the file will be created.
            if (!File.Exists(_fileName))
            {
            File.CreateText(_fileName); 
            }
               
    }

   public void SaveToFile(string fileName)
   {
    using (StreamWriter outputFile = new StreamWriter(fileName /*true*/)) //filename is not a bool term
    {

        Console.WriteLine("Saving to file...");

        //A for loop to iterate through the string list
        //and save items in list to MyJournal.txt
        foreach (string e in entry/*entries*/)
            {
                outputFile.WriteLine(e);
            }
        }

       //Write the contents of List<Journal> to the MyJournal.json file
      // string json = JsonSerializer.Serialize(_entries);
       //File.WriteAllText(_fileName, json);
    }

    public void  DisplayJournalEntries()
    {
        string jText = File.ReadAllText(_fileName);
        Console.WriteLine(jText);
    }

   
   
}