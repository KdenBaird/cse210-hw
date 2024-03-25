using System.Diagnostics;

public class CBActivity
{
    //Attributes:
    //Each activity should start with a common starting message that provides 
    //the name of the activity, a description, and asks for and sets the duration 
    //of the activity in seconds. Then, it should tell the user to prepare to begin and pause for several seconds.
    private string _cjbstartingMessage;

    //Each activity should end with a common ending message that tells the user they have done a good job, and pause 
    //and then tell them the activity they have completed and the length of time and pauses for several seconds before finishing.
    private string _cjbendingMessage;
     private float _cjbduration;
     
     //ask if this list should be set up here or in the list class.
     private List <string> _cjbpromptList = new List <string> 
     {
        "Who are people that you appreciate?",
        "Who are people that you have helped this week?",
        "What are personal strengths of yours?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
     };

     //Constructors:
     Random random = new Random();

     //Ask if I need this constructor and what it does.
     //CBActivity a = new CBActivity(string _cjbstartingMessage, string _cjbendingMessage, List <string> _promptList);
    

    //Methods:
    public string GetRandomPrompt()
    {
        int randomIndex = random.Next(_cjbpromptList.Count);
        string randomInt = _cjbpromptList[randomIndex];
        return randomInt;
    }
    
    //Ask or see if this  method can be static: 
     public void DisplayStartMsg()
    {
        //call GetDuration()
        //Breathing intro line:
        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        
        //Reflection intro line:
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

        //Listing intro line: 
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }

    public void DisplayEndMsg()
    {
        
    }

    public float SetDuration()
    {
        return _cjbduration;
    }

    public void GetDuration()
    {
        
        //Prompts user to choose the duration and convert their time.
        Console.WriteLine("Set the duration for each breath: ");
        float _cjbduration = float.Parse(Console.ReadLine());
    }

}