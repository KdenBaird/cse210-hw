public class CBPrompt
{
    public List<string> _cjbpromptsList = new List<string>{"What was the best part of your day?",
    "What is something you are proud you did today?",
    "What was something you wish you did better today?",
    "What is something that you learned today?",
    "Evaluate or discuss your actions today, what did you do right today? What did you do wrong?",
    };
    
    public string _cjbpreviousPrompt = null;
    public string _cjbprompt;

    public int randomnumber;

    public CBPrompt(){}
    
    Random random = new Random();
    public List <string> added_prompts = new List <string>{};

    public string GeneratePrompt()
    {
        
        int index;

        //if (_cjbpromptsList.Count <= 1 || _cjbpreviousPrompt == null)
        
        if (_cjbpromptsList.Count > 0) 
        {
            index = random.Next(0, _cjbpromptsList.Count);
             _cjbprompt = _cjbpromptsList[index];
            _cjbpromptsList.Remove(_cjbprompt);
            return _cjbprompt;
        }
    //index = random.Next(0, _cjbpromptsList.Count);
    // _cjbpreviousPrompt = _cjbpromptsList[index];
     //_cjbpromptsList.Remove(_cjbpreviousPrompt);
    else 
        {
            Console.WriteLine("There are no  more prompts. Please write another prompt: ");
            string added_items = Console.ReadLine();
            _cjbpromptsList.Add(added_items);
            return added_items;
        }   
    }
}
