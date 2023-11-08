using System;

public class Shape
{
    //Attributes of Shape
    protected string _color;



    //Get Set for color
    public string GetColor()
    {
        return $"{_color}";
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    //Constructor for shape
    public Shape(string color)
    {
        _color = color;
    }



    //Virtual method for GetArea
    public virtual double GetArea()
    {
        return 0;
    }


}