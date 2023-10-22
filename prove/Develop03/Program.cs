using System;

class Program
{
    static void Main(string[] args)
    {
        //Instantiateing the Reference and Scripture classes 
        //including passing the Reference and text information
        //as parameters in the Class Constructors
        Reference reference = new Reference("2 Nephi", "1", "15");

        //Console.WriteLine(reference.GetReferenceString());
        Scripture scripture = new Scripture("But behold, the Lord hath redeemed by soul from hell; I have beheld his glory, and I am encircled about eternally in the arms of his love.", reference);
    
        //Using a while loop to clear the console, call the
        //DisplayScripture method, take user input for the
        //program to hide words upon pressing Enter or quitting
        //the program upon writing 'quit'.
        while(true)
        {
            Console.Clear();
            scripture.DisplayScripture();
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit the program.");


            string userInput = Console.ReadLine();
            if (userInput == "quit")
                break;
            
            else if (userInput == "")
            {

                // User presses enter. if all the words are hidden the break. 
                // otherwise hide words

                if (scripture.WordsHidden())
                {
                    break;
                }
                else
                {
                    scripture.HideWords();
                }
            }





        }
}
}