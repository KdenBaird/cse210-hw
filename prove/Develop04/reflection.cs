public class CBReflection : CBActivity
{
    //Attributes:
    //INCLUDE THE PROMPTLIST AND CJBQUESTIONS IN BASE CLASS?
    List <string> _cjbpromptList = new List <string> 
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    
    List <string> _cjbquestionList = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    //Constructors:
    public CBReflection(float duration) : base(duration)
    {

    }
 
    //Methods:
    
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_cjbpromptList.Count);
        string randomInt = _cjbpromptList[randomIndex];
        return randomInt;
    }

    public override void DisplayStartMsg()
    {
        //Reflection intro line:
        Console.WriteLine("Welcome to the Reflection Activity. \n");
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.\n");
        
        Console.WriteLine("Consider the following prompt: \n");

        Console.WriteLine(GetRandomPrompt());

        Console.WriteLine("When you have something in mind, press enter to continue.");
        string input = Console.ReadLine();
        if (input != "quit")
        {
            //DateTime startTime = DateTime.Now;
            //DateTime endTime = startTime.AddSeconds(_cjbduration);
            StartReflection();

        }
    }

    public void StartReflection()
    {
        Console.WriteLine("Ponder on each of the following questions as it relates to the experience.");
        Console.Write("You may begin in: ");
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        //After countdown clear console:
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_cjbduration);

       
        while (DateTime.Now < endTime)
        {
            Random random = new Random();
            int randomIndex = random.Next(_cjbquestionList.Count);
            string randomInt = _cjbquestionList[randomIndex];
            Console.WriteLine(randomInt);
            for (int i = 9; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
        DisplayEndMsg();
    }

    public override void DisplayEndMsg()
    {
        Console.WriteLine($"Well done you have completed another {_cjbduration} seconds of the Listing Activity.");
        Thread.Sleep(5000);
        Console.Clear();
    }
}