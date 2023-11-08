using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square sq1 = new Square("Yellow", 8);              
        shapes.Add(sq1);

        Rectangle r1 = new Rectangle("Purple", 9, 4);
        shapes.Add(r1);

        Circle c1 = new Circle("Blue", 5);
        shapes.Add(c1);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();

            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}