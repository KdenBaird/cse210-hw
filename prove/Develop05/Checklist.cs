public class CBChecklist : CBGoals
{
    //Attributes:
    private int _cjbBonusPoints;
    private int _cjbStepsCompleted;
    private int _cjbNumOfTimes;

    //Constructors:
    public CBChecklist(string GoalName, int GoalPoints) : base(GoalName, GoalPoints)
    {
        _cjbGoalName = GoalName;
        _cjbGoalPoints = GoalPoints;
    }
    public CBChecklist()
    {

    }
    public void  SetNumOfTimes(int ParNumOfTimes)
    {
        _cjbNumOfTimes = ParNumOfTimes;
    }
    public void SetBonusPoints(int ParBonusPoints)
    {
        _cjbBonusPoints = ParBonusPoints;
    }
    public override void PrintGoalInfo(string checkmark, int displaynumofgoal)
    {
        Console.WriteLine($"{displaynumofgoal} [{checkmark}] {_cjbGoalName}");
    }
    

    //Methods:
     public override CBChecklist CreateNewGoal()
    {
        CBChecklist ret = new();
        Console.WriteLine("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        ret.SetGoalName(goalName);
        //TODO: Do the same thing for points, and other criteria except is goal completed. (make the setter and add)
        Console.WriteLine("How many points do you want this goal to be? ");
        int points = int.Parse(Console.ReadLine());
        ret.SetGoalPoints(points);
        Console.WriteLine("How many times does this goal need to be completed for a bonus? ");
        int numOfTimes = int.Parse(Console.ReadLine());
        ret.SetNumOfTimes(numOfTimes);
        Console.WriteLine($"What is the bonus for completing it {numOfTimes} times? ");
        int bonusPoints = int.Parse(Console.ReadLine());
        ret.SetBonusPoints(bonusPoints);
        return ret;
    }
    public override int DisplayGoalPoints()
    {
        return 0;
    }

}