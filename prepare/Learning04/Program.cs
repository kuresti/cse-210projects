using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Samuel Bennet", "Multiplication");
        Console.WriteLine(assignment1.GetSummary());
        
        //Math Assignment derived from Assignment class
        MathAssignment math1 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeworkList());

        //Writing Assignment derived from Assignment class
        WritingAssignment write1 = new WritingAssignment("Mary Waters", "European History", "The Causes fo World War II");
        Console.WriteLine(write1.GetWritingAssignment());
    }
}