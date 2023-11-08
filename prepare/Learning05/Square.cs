using System;

public class Square : Shape
{
    //Square Attributes
    private double _side;

    //Square Constructor
    public Square(string color, double side) : base (color)
    {
                _side = side;
    }

    //GetArea method 
    public override double GetArea()
    {
        return _side * _side;
    }
}