using System;

class Program
{
    //Welcome to program function
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    //User Name prompt function
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    //Favorite number function
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string userNumber = Console.ReadLine();
        int number = int.Parse(userNumber);
        return number;
    }

    //Squared number function
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    //Display result function
    static void DisplayResult(string userName, int square)
    {
        Console.WriteLine($"{userName}, the square of your number is {square}");
    }

    //Calling Main method to call functions
    static void Main(string[] args)
    {
        //Welcome
        Program.DisplayWelcome();

        //Functions getting prompts from user
        int favoriteNumber = PromptUserNumber();
        string name = PromptUserName();

        //Functions that take parameters
        int numberSquared = SquareNumber(favoriteNumber);
        Program.DisplayResult(name, numberSquared);
    }
}