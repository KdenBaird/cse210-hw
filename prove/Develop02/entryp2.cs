public class CBEntry
{
    public string _cjbprompt;
    public string _cjbdate; 
    public string _cjbinput;
    public string DisplayPrompt()
    {
        CBPrompt p = new CBPrompt();
        string randomPrompt = p.GeneratePrompt();
        return randomPrompt;
    }

    public string GetUserInput()
    {
        string userEntry = Console.ReadLine();
        return userEntry;
    }

}
