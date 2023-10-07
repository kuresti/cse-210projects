using System;
using System.Collections;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

public class Journal
{
    //attributes of Journal class
  
    public string _fileName =  "MyJournal.txt";
   public string _journalFile;

   
   public string _entry;

    //Empty list to hold journal entries
    public List<JournalEntry> _entries = new List<JournalEntry>();
    
    //Instance of JournalEntry
    JournalEntry newJournalEntry = new JournalEntry();
    
    public void AddEntry()
    {
        newJournalEntry.AddEntry();
    }

    //Behaviors of Journal class
    public void LoadJournal()
    {
        
            Console.Write("Please enter the file name (MyJournal.txt): ");
            Console.ReadLine();
            if (!File.Exists(_fileName))
            {
            File.CreateText(_fileName); 
            }
               
    }

   public void SaveToFile()
   {
    using (StreamWriter outputFile = new StreamWriter(@"C:\Users\kures\OneDrive\Documents\byuiClasses\cse-210projects\prove\Develop02\MyJournal.txt_fileName", true))
    {
        foreach (string e in newJournalEntry.entry)
            {
                outputFile.WriteLine(e);
            }
        }

       //Write the contents of List<Journal> to the MyJournal.json file
      // string json = JsonSerializer.Serialize(_entries);
       //File.WriteAllText(_fileName, json);
    }

    public void DisplayJournalEntries()
    {
        //dynamic _entries
    }

   
   
}