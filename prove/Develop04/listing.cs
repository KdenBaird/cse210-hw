public class CBListing : CBActivity
{
    //Attributes: 
    private List <string> _cjbquestions = new List <string> 
     {
        "Who are people that you appreciate?",
        "Who are people that you have helped this week?",
        "What are personal strengths of yours?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
     };
    
    
    //Ask about constructors:
    //Constructors
    public CBListing(float duration) : base (duration)
    {
      
    }
    

    //Methods:
    public void StartListingActivity()
    {
         List<string> answersList = new List<string>();
        
        Console.WriteLine("List as many responses as you can to the following prompt: \n");
        Console.WriteLine(GetRandomQuestion());

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_cjbduration);

       
        while (DateTime.Now < endTime)
        {
            // Check if there's input available to read
            if (Console.KeyAvailable)
            {
                string answer = Console.ReadLine();
                answersList.Add(answer);
            }
        }
        //This is a test to see if itesm are being added to teh list. 
        Console.Clear();
        int numOfAnswers = answersList.Count();
        Console.WriteLine($"You have answered {numOfAnswers} times!");
        Thread.Sleep(5000);
        DisplayEndMsg();
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int randomIndex = random.Next(_cjbquestions.Count);
        string randomq = _cjbquestions[randomIndex];
        return randomq;
    }
    public override void DisplayStartMsg()
    {
        Console.WriteLine("Welcome to the Listing Activity! \n");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        StartListingActivity();
    }

    public override void DisplayEndMsg()
    {
        Console.WriteLine($"Well done! You have completed another {_cjbduration} seconds of the Listing Activity.");
        Thread.Sleep(5000);
        Console.Clear();
    }
}