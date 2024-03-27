using System.Drawing;
using System.Dynamic;

//This class is abstract because the method within "GetArea() doesn't have anything in it.
public abstract class Shape 
{
    private string _color;

    public Shape (string color)
    {
        _color = color;
    }
    
    
    //Methods:
    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;

    }
    //USE the behavior in the base class that all derived classes will use: but how to get that will be defined in derived classes.
    //SIDE NOTE: method in the base class won't be implemented, but will be defined given each individual class.
    //This functino is abstract because it has no implementation. IE there's nothing in the function. you use abstract when not putting anythign in it.
    public abstract double GetArea(); 
}