public class CBBreathing : CBActivity
{
    //Attributes: None
    //Constructors:
    
    //Any paramater that is within the constructor, should be "required not limited to." You would add it into the parameter if it's going to be changed or manipulated.
    // If the parameter is a member variable hard coded at the top, then it doesn't need to be included.
   public CBBreathing(float duration) : base(duration)
   {
        
   }
   public CBBreathing(float duration, int optinoal) : base(duration)
   {

   }
   
   
    
    // Methods:
    public void DisplayBreathSequence()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_cjbduration);

       
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            for (int i = 5; i > 0; i--)
            {
               
                
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
                
            }
            Console.WriteLine("Breathe out...");

            for (int i = 5; i > 0; i--)
            {
                
                
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
                
            }
            Console.WriteLine();
            
        }
            
            
            Console.WriteLine();
        
        DisplayEndMsg();
    }

    public override void DisplayStartMsg()
    {
        //Breathing intro line:
        Console.WriteLine("\nWelcome to the Breathing Activity.");
        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.\n");
        DisplayBreathSequence();
    }

        public override void DisplayEndMsg()
        {
            Console.WriteLine($"Well done you have completed another {_cjbduration} seconds of the Breathing Activity.\n");
            Console.WriteLine("Returning to main menu in:");
            for (int i = 5; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
                
            }
            Console.Clear();
        }
}