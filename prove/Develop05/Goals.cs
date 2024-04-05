using System.Globalization;

public class CBGoals
{
    //Attributes:
    protected string _cjbGoalName;
    protected int _cjbGoalPoints = 0; 
    protected bool _cjbGoalCompleted = false;
    //Constructors:
    public CBGoals()
    {

    }
    CBProgram p = new();
    protected CBGoals(string GoalName, int GoalPoints, bool GoalCompleted)
    {
        _cjbGoalName = GoalName;
        _cjbGoalPoints = GoalPoints;
        _cjbGoalCompleted = GoalCompleted;
    }
    protected CBGoals(string GoalName, int GoalPoints)
    {
        _cjbGoalName = GoalName;
        _cjbGoalPoints = GoalPoints;
    }
    //Methods:
    public void SetGoalCompleted(bool GoalCompleted)
    {
        _cjbGoalCompleted = GoalCompleted;
    }
    public bool GetGoalCompleted()
    {
        return _cjbGoalCompleted;
    }
    public void SetGoalName(string goal)
    {
        _cjbGoalName = goal;
    }
    public void SetGoalPoints(int points)
    {
        _cjbGoalPoints = points;
    }
    public int GetGoalPoints()
    {
       return _cjbGoalPoints;
    }
    public virtual int CalcPoints()
{
    return _cjbGoalPoints; // Return the points associated with the goal
}

    //double check if this return type is bool
    public virtual void MarkCompleted()
    {
        Console.WriteLine("Mark Completed: ");
    }
    // the program will know the type of goal. override this fucntion in the child methods. 
    public virtual void PrintGoalInfo(string checkmark, int displaynumofgoal)
    {
        Console.WriteLine($"{displaynumofgoal} [{checkmark}] {_cjbGoalName}");
    }
    public string GetStringRepresentation()
    {
    return $"{GetType().Name}:{_cjbGoalName},{_cjbGoalPoints},{_cjbGoalCompleted}";
    }
    public void SaveGoalsToFile(List<CBGoals> goals, string fileName)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (CBGoals goal in goals)
                {
                    writer.WriteLine(goal.GetStringRepresentation());
                }
            }
            Console.WriteLine("Goals saved successfully.");
        }
        catch (Exception exception)
        {
            Console.WriteLine($"Error occurred while saving goals: {exception.Message}");
        }
    }
    public List<CBGoals> LoadGoalsFromFile(string fileName)
    {
    List<CBGoals> loadedGoals = new List<CBGoals>();
    try
    {
        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(':');
                if (parts.Length == 2)
                {
                    string typeName = parts[0];
                    string[] details = parts[1].Split(',');
                    if (typeName == "CBGoals")
                    {
                        string goalName = details[0];
                        int goalPoints = int.Parse(details[1]);
                        bool goalCompleted = bool.Parse(details[2]);
                        CBGoals goal = new CBGoals(goalName, goalPoints, goalCompleted);
                        loadedGoals.Add(goal);
                    }       
                }
            }
        }
        Console.WriteLine("Goals loaded successfully.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error occurred while loading goals: {ex.Message}");
    }
    return loadedGoals;
    }

     /*public virtual void ListGoals(List <CBGoals> GoalList)
    {
        int count = 0;
        Console.WriteLine("Listing Goals:");
        foreach (CBGoals goal in GoalList)
        {
            string blankSpace = " ";
            bool completed = goal.GetGoalCompleted();
            if (completed)      
            {
                blankSpace = "X";
            }
            count++;
            goal.PrintGoalInfo(blankSpace, count);
        }
    }
    */
    public virtual void ListGoalsWithVisualFeedback(List<CBGoals> GoalList)
    {
    Console.WriteLine("Listing Goals with Visual Feedback:");
    foreach (CBGoals goal in GoalList)
    {
        string statusSymbol = goal.GetGoalCompleted() ? "✔️" : "❌";
        Console.WriteLine($"{statusSymbol} {goal._cjbGoalName}");
    }
    }

    public void ListGoalsFromRecord(List<CBGoals> GoalList, CBProgram program)
    {
        Console.WriteLine("The goals are: ");
        for (int i = 0; i < GoalList.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {GoalList[i]._cjbGoalName}");
        }
        
        Console.WriteLine("Which goal did you accomplish? ");
        int accomplishedGoalIndex = int.Parse(Console.ReadLine()) - 1; // Subtract 1 to get the correct index

        if (accomplishedGoalIndex >= 0 && accomplishedGoalIndex < GoalList.Count)
        {
            CBGoals accomplishedGoal = GoalList[accomplishedGoalIndex];
            if (!(accomplishedGoal is CBEternal))
            {
                Console.WriteLine($"Congratulations! You completed the goal '{accomplishedGoal._cjbGoalName}' with {accomplishedGoal._cjbGoalPoints} points.");
                accomplishedGoal.SetGoalCompleted(true);
                program.UpdateTotalPoints(accomplishedGoal._cjbGoalPoints);
            }
            else 
            {
                Console.WriteLine($"The goal '{accomplishedGoal._cjbGoalName}' is an eternal goal and can't be checked off the list.");
                program.UpdateTotalPoints(accomplishedGoal._cjbGoalPoints);
            }
        }
        else
        {   
            Console.WriteLine("Invalid goal. Enter the number of the goal.");
        }
    }
    public virtual CBGoals CreateNewGoal()
    {
       return new CBGoals();
    }
    public virtual int DisplayGoalPoints()
    {
        return 0;
    }
}
