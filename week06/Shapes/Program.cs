using System;
using System.Formats.Asn1;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Square hi = new Square("Blue", 5);
        double area = hi.GetArea();
        //Console.WriteLine($"The area is {area} and color is {hi.GetColor()}");

        Rectangle rect = new Rectangle("Green", 6, 4);
        //Console.WriteLine($"The area is {rect.GetArea()} and color is {rect.GetColor()}");
        Circle circle = new Circle("Red", 2);
        //Console.WriteLine($"The area is {circle.GetArea()} and color is {circle.GetColor()}");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(hi);
        shapes.Add(rect);
        shapes.Add(circle);
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The area is {shape.GetArea()} and the color is {shape.GetColor()}");
        }

    }
}