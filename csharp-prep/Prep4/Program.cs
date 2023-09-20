using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        //Create empty list for numbers
        List<int> numbers = new List<int>();

        //Directions for making number list
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        //Initializing variables
        int number = -1;
        string entry = "";

        //While loop to add user input to numbers list
        while (number != 0)
        {
        
        //Prompt to add numbers to list
        Console.Write("Enter number: ");
        entry = Console.ReadLine();
        number = int.Parse(entry);

        //Adding user input number to numbers list
        numbers.Add(number);
        }
        //The sum of numbers list using the Sum() method
        int total = numbers.Sum();
        Console.WriteLine($"The sum is: {total}");

        //The average of numbers list using the Average() method
        double median = numbers.Average();
        Console.WriteLine($"The average is: {median}");

        //The largest number in numbers list using the Max() method
        int max = numbers.Max();
        Console.WriteLine($"The largest number is: {max}");

        //The smallest postitive number in numbers list
        numbers.Sort();
       
       Console.WriteLine("The sorted list is:");
        
        //foreach loop to iterate through list sorting list by number
        foreach (int x in numbers)
        {
            if (x != 0)
            Console.WriteLine(x);
        }
        
        



        
    }
}