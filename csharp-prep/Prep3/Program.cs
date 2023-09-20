using System;
using System.Formats.Asn1;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
       
      //Initializing answer
    string answer = "";
      //Do while loop to replay game
    do
    {
      //Randomizer
      Random randomGenerator = new Random();
      int magicNumber = randomGenerator.Next(1, 100);

      //Initializing guess
      int guess = 0;
    // Initializing count 
     int count = 0;
    
    

    
    //While loop to keep guessing until correct
    while ((guess != magicNumber) && count > -1)
    {
       //counter
       count++;
     //Guess
      Console.Write("What is your guess? ");
      guess = int.Parse(Console.ReadLine());
        //If statement to determine if guess is correct
        if (guess < magicNumber)
        {
            Console.WriteLine("Higher");
        }
        else if (guess > magicNumber)
        {
            Console.WriteLine("Lower");
        }
        else 
        {
            Console.WriteLine ("You guessed it!");
            Console.WriteLine($"You got it right in {count} guesses.");
            Console.Write("Do you want to play again?");
            answer = Console.ReadLine();
        }
        } 
    }while (answer == "yes");
    
}
} 

     
     
    
    

