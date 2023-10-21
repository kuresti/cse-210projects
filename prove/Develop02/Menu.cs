using System;

public class Menu
{

    //Attribte of Menu Class

    //variable for user choice
    public string _choice = "";

    //variable to validate user choice
    public bool _validChoice = false;

    //Constructor for Menu
    public Menu()
    {
    }    

    //New instance of Journal Class
    Journal myJournal = new Journal();

    

     //Behaviors/methods of Menu class
    //while loop to iterate through menu options for user to choose an option
    public void DisplayMenu()
    {
        do
        {
        Console.WriteLine("\nWelcome to My Journal App!");
        Console.WriteLine("Please choose one of the following menu items: ");        
        Console.WriteLine("1. Write a journal entry.");
        Console.WriteLine("2. Load journal from file");
        Console.WriteLine("3. Save journal to file");
        Console.WriteLine("4. Display journal entries.");
        Console.WriteLine("5. Quit program.");

        //Gets the user's choice
         _choice = Console.ReadLine();
        
        //validates user's  choice
         if (_choice =="1" || _choice == "2" || _choice == "3" || _choice == "4" || _choice == "5")
         {
            _validChoice = true;
         }
         else
         {
            Console.WriteLine("\nYour choice is not valid. Please choose 1-5.\n");
         }

         
        switch (_choice)
        {
            case "1":
               myJournal.AddEntry();
                break;
            
            case "2":
                myJournal.LoadJournal();
                break;

            case "3":
                //set a prompt to ask user for filename
                //with the input set to filename as a variable
                //then pass the filename variable into the savetofile method
                myJournal.SaveToFile();
                break;

            case "4":
                myJournal.DisplayJournalEntries();
                break;

            case "5":
                break;

        }
        } while (_choice != "5");
    }

    public void ExitProgram()
        {
            System.Environment.Exit(0);
        }
    
}
    
            
            


  