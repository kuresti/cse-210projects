using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction testFraction1 = new Fraction();
        Fraction testFraction2 = new Fraction(6);
        Fraction testFraction3 = new Fraction(6, 7);

        Fraction f = new Fraction();
        f.SetTopNumber(1);
        Console.WriteLine(f.GetFractionString());
        Console.WriteLine(f.GetTopNumber());

        f.SetTopNumber(5);
        Console.WriteLine(f.GetFractionString());
        Console.WriteLine(f.GetTopNumber());

        f.SetTopNumber(3);
        f.SetBottomNumber(4);
        Console.WriteLine(f.GetFractionString());
        Console.WriteLine(f.GetDecimalValue());

        f.SetTopNumber(1);
        f.SetBottomNumber(3);
        Console.WriteLine(f.GetFractionString());
        Console.WriteLine(f.GetDecimalValue());


        
    }
}