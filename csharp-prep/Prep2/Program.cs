using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradePercent = Console.ReadLine();
        int gradeNumber = int.Parse(gradePercent); 

        string letter = "";
        int sign = gradeNumber % 10;
        string gradeSign = "";

        if (sign >= 7)
        {
            gradeSign = "+";
        }
        else if (sign < 3)
        {
            gradeSign = "-";
        }
        else
        {
            gradeSign = "";
        }
        if (gradeNumber >= 90)
        {
            letter = "A";
        }
        else if (gradeNumber >= 80)
        {
            letter = "B";
        }
        else if (gradeNumber >= 70)
        {
            letter = "C";
        }
        else if (gradeNumber >= 60)
        {
            letter = "D";
        }    
        else if (gradeNumber < 60)
        {
            letter = "F";
        }

        if (letter == "A" && gradeSign == "+")
        {
            Console.WriteLine($"Your grade for the class is {letter}.");
        } 
        else if ((letter == "F") && (gradeSign == "+" || gradeSign == "-"))
        {
           Console.WriteLine($"Your grade for the class is {letter}."); 
        } 
        else
        {
            Console.WriteLine($"Your grade for the class is {letter}{gradeSign}.");
        }
                if (gradeNumber >= 70)
                {
                    Console.WriteLine("Congratulations! You passed the class!");
                }
                else if (gradeNumber < 70)
                {
                    Console.WriteLine("This grade does not reflect on you as a person. This is just a blip in your story.");
                }
                

                              
            
       }
    }
