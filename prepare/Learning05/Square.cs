public class Square : Shape
{
private double _side;

//Ask alec why we declare side inside of this constructor or how we can do that.
public Square(string color, double side) : base (color)
{
    _side = side;
}

    public override double GetArea()
    {
        return _side * _side;
    }
}