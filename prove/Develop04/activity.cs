using System.Diagnostics;

public abstract class CBActivity
{
    //Attributes:
    protected float _cjbduration;
 
    //Constructors:
    protected CBActivity(float cjbduration)
    {
        _cjbduration = cjbduration;
        DisplayStartMsg();
    }

    //Methods:

    public abstract void DisplayStartMsg();

    public abstract void DisplayEndMsg(); 

}