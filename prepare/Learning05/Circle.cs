public class Circle : Shape
{

    private int _radius;

    public Circle(string color, int radius) : base (color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return 3.1415 * _radius * _radius ;
    }
    
}