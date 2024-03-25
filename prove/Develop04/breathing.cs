public class CBBreathing : CBActivity
{
    //Attributes: None

    //Constructors:
    
    
    //Breathing (string, string, List <string>) : base (string, string, List, <string>)
    //Calls base constructor to set activity parameters. 
    
    // Methods:
    //Ask if we need a "return type" for each method.
    public void DisplayBreathSequence()
    {

    }

    public void Run()
    {
        //Calls StartMsg()
        CBActivity.DisplayStartMsg();
        //Starts breathing activity
        //Calls other breathing class methods as needed.
        //Calls EndActivity() from activity class.
    }
}