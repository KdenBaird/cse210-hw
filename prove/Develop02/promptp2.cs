public class Prompt
{
    
    public List<string> _promptsList = new List<string>{"What was the best part of your day?",
    "What is something you are proud you did today?",
    "What was something you wish you did better today?",
    "What is something that you learned today?",
    "Evaluate or discuss your actions today, what did you do right today? What did you do wrong?",
    };

    public string _prompt;


    public string GeneratePrompt()
    {
        Random random = new Random();
        int index = random.Next(1, _promptsList.Count);
        _prompt = _promptsList[index];
        return _prompt;
    }
    
}
