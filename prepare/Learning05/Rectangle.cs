using System;

public class Rectangle : Shape
{
    //Attribute of Rectangle
    private double _length;
    private double _width;

    //Rectangle Constructor
    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }

    //GetArea Override
    public override double GetArea()
    {
        return _length * _width;
    }

}