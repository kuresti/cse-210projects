using System;

public class Circle : Shape
{
    //Circle attributes
    private double _radius;

    //Circle Constructor
    public Circle(string color, double radius) : base (color)
    {
        _radius = radius;
    }

    //GetArea Override method
    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }
    

}