public class CBEternal : CBGoals
{
    private int _cjbTimesCompleted = 0;

    public CBEternal (string GoalName, int GoalPoints, bool _cjbCompleted) : base (GoalName, GoalPoints)
    {
        _cjbGoalName = GoalName;
    }
     public CBEternal()
    {

    }
    public override int CalcPoints()
    {
        return 0;
    }
    public override CBEternal CreateNewGoal()
    {
        CBEternal ret = new();
        Console.WriteLine("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        ret.SetGoalName(goalName);
        Console.WriteLine("How many points do you want this goal to be? ");
        int points = int.Parse(Console.ReadLine());
        ret.SetGoalPoints(points);
        return ret;
    }
     /*public override int DisplayGoalPoints()
    {
        return 0;
    }
    */
}