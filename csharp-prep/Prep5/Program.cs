using System;

class Program
{
    static void Main(string[] args)
    {
        //Function that displays message
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        //Call DisplayWelcome Function
        DisplayWelcome();

        //Function that gets user input and returns
        //it as a string
        static void PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
        }

        //Call PromptUserName Function
        PromptUserName();

        //Functions that gets user's favorite number (as an integer)
        static void PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int favoriteNumber = int.Parse(Console.ReadLine());
            

        }

    }

}