using System;

public class Menu
{

    //Attribte of Menu Class

    //boolean attribute set to true
    //public bool _choice =  true;

    //Constructor for Menu
    public Menu()
    {
    }

    //New instance of PromptGenerator Class
    PromptGenerator newPrompt = new PromptGenerator();

    //variable for user choice
    public string _choice;



     //Behaviors/methods of Menu class
    //while loop to iterate through menu options for user to choose
    public void DisplayMenu()
    {
        
            
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Load");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Display");
            Console.WriteLine("5. Exit");
            
            _choice = Console.ReadLine();
            
           switch (_choice)
           {
                case "1":                    
                    newPrompt.DisplayPrompt();
                    break;

                case "2":

                case "3":

                case "4":
                
                case "5":
                    ExitProgram();
                    break;

                
                
           }
            
            
        
    }

    public void ExitProgram()
        {
            System.Environment.Exit(0);
        }
    
}
  