public class CBListing : CBActivity
{
    //Attributes: None


    //Constructors:
    public CBListing(string _cjbstartingMessage, string _cjbendingMessage, List <string> _cjbpromptList) : base(string _cjbstartingMessage, string _cjbendingMessage, List <string> _cjbpromptList);
    // Calls base constructor to set activity parameters.2.2522.

    
    //Methods:
    public string GetAnswer()
    {
        //Get the user's answer.
        return;

    }

    public void Run()
    {
        //Calls Start Activity() from activity class.
        //Starts the listing activity
        //Calls other listing class methods as needed.
        GetRandomPrompt();
        //Calls EndActivity() from activity class.
    }
}