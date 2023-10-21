using System;

public class JournalEntry
{
  
   public string _location;
   public string _locationPrompt;
   public string _response;
   public string _prompt;
   public string _todayDate;
   

   public List<JournalEntry> entry = new List<JournalEntry>();

    //New instance of PromptGenerator Class
    PromptGenerator newPrompt = new PromptGenerator();

    //New instance of Journal Class
    // Journal newJournal = new Journal();



   public void AddEntry()
    {
         //JournalEntry _dailyEntry = new JournalEntry();
         DateTime date1 = DateTime.Now;
        _todayDate = "\nDate: " + date1;
         Console.WriteLine($"\n{_todayDate}");
         _locationPrompt = "What is your location? ";
         Console.Write(_locationPrompt);
        _location = Console.ReadLine();
         _prompt = newPrompt.DisplayPrompt();
         Console.Write($"{_prompt}\n");
        _response = Console.ReadLine();

        entry.Add(_todayDate);
        entry.Add(_locationPrompt);
        entry.Add(_location);
        entry.Add(_prompt);
        entry.Add(_response);
        // Console.Write(entry[0]);
       // newJournal._entries.Add(_dailyEntry);

       // foreach (JournalEntry e in newJournal._entries)
       // {
        //    Console.WriteLine(_dailyEntry._todayDate);
      //  }
        
        

        //Adding entries to _entries list in json format
        //_entries.Add(new Journal()
        //{
         //   _todayDate = "Date: " + date1,
         //   _locationPrompt = "What is your location? ",
         //   _location = Console.ReadLine(), 
         //   _prompt = newPrompt.DisplayPrompt(),
         //   _response = Console.ReadLine(),  
       // });

        
         
    }  
}