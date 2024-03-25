using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List <Shape> shapes = new List <Shape>();

        Square sq1 = new Square("red", 3);
        shapes.Add(sq1);

        //When we're creating a new instance of rectangle and add that to the list, does the computer just read everything in that class and return what the output was?
        Rectangle r1 = new Rectangle("blue", 3, 5);
        shapes.Add(r1);

        Circle c1 = new Circle("orange", 5);
        shapes.Add(c1);


        foreach (Shape s in shapes)
            {
                // Notice that all shapes have a GetColor method from the base class
                string color = s.GetColor();

                // Notice that all shapes have a GetArea method, but the behavior is
                // different for each type of shape
                double area = s.GetArea();

                Console.WriteLine($"The {color} shape has an area of {area}.");
            }
    }
}