public class CBReflection : CBActivity
{
    //Attributes:
    List <string> _cjbquestions;
    
    //Constructors:
    //(Reflection(string, string, List<string> List<string>) : base (string, string, List<string>)
    //Sets class attributes and calls base constructor to set activity parameters

    //Ask if I'm supposed to make all methods public?
    //Methods:
    public string GetRandomQuestion()
    {
        //Generates random question from _cjbquestions

    }

    public void Run()
    {
        //Calls StartActivity() from activity class--
        //Starts the reflection activity
        //Calls other reflection class methods as needed.
        // Call EndActivity() from activity class
        CBActivity.DisplayEndMsg();
    }
}