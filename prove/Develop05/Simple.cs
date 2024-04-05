public class CBSimple : CBGoals
{
    //Attributes: None

    //Constructors:
   public CBSimple(string GoalName, int GoalPoints) : base(GoalName, GoalPoints)
   {
    
   }
   public CBSimple()
    {

    }
    //Methods:
    public override void MarkCompleted()
    {
        
    }
    public override CBSimple CreateNewGoal()
    {
        CBSimple ret = new();
        Console.WriteLine("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        ret.SetGoalName(goalName);
        //TODO: Do the same thing for points, and other criteria except is goal completed. (make the setter and add)
        Console.WriteLine("How many points do you want this goal to be? ");
        int points = int.Parse(Console.ReadLine());
        ret.SetGoalPoints(points);
        return ret;
    }

    public override int DisplayGoalPoints()
    {
        return 0;
    }
    

    public override int CalcPoints()
    {
        return 3;
    }
    
}