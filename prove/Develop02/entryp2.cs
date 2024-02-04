public class Entry
{
    public string _prompt;
    
        
    public string _date; 
    public string _input;

    
    
    public string DisplayPrompt()
    {
        Prompt p = new Prompt();
        string randomPrompt = p.GeneratePrompt();
        return randomPrompt;
    }


    public string GetUserInput()
    {
        
        string userEntry = Console.ReadLine();
        
        return userEntry;

    }

}
