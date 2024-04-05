using System;
using System.Collections.Generic;
using System.IO;

public class CBProgram
{
    // Attributes:
    private List<CBGoals> _cjbListOfGoals;
    private int _cjbTotalPoints = 0;
    private string fileName;
    // Methods:
    public CBProgram()
    {
        _cjbListOfGoals = new List<CBGoals>();
    }
    public void DisplayMenu()
    {
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
    }
    public void UpdateTotalPoints(int points)
    {
        _cjbTotalPoints += points;
    }
    public void DisplayMenu2()
    {
        Console.WriteLine("The Types of Goals are: ");
        Console.WriteLine("1 Simple Goal");
        Console.WriteLine("2 Eternal Goal");
        Console.WriteLine("3 Checklist Goal\n");
        Console.WriteLine("Which type of goal would you like to create?");
    }
    public void SaveGoalsViaInput(List<CBGoals> goals)
    {
        Console.WriteLine("Enter the filename to save the goals:");
        fileName = Console.ReadLine();
        CBGoals g = new();
        g.SaveGoalsToFile(goals, fileName);
    }
    public void LoadGoalsFromFile()
    {
        if (File.Exists(fileName))
        {
            CBGoals g = new();
            _cjbListOfGoals = g.LoadGoalsFromFile(fileName);
            Console.WriteLine(_cjbListOfGoals);
        }
        else
        {
            Console.WriteLine("File not found. Please save goals before attempting to load.");
        }
    }
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        CBProgram p = new();
        bool done = false;
        
        while (!done)
        {
            Console.WriteLine($"\nYou have {p._cjbTotalPoints} points.\n");
            CBGoals listObject = new();
            p.DisplayMenu();
            string input = Console.ReadLine();
            
            switch (input)
            {
                case "1":
                    p.DisplayMenu2();
                    string input2 = Console.ReadLine();
                    if (input2 == "1")
                    {
                        p._cjbListOfGoals.Add(new CBSimple().CreateNewGoal());
                    }
                    else if (input2 == "2")
                    {
                        p._cjbListOfGoals.Add(new CBEternal().CreateNewGoal());
                    }
                    else if (input2 == "3")
                    {
                        p._cjbListOfGoals.Add(new CBChecklist().CreateNewGoal());
                    }
                    break;

                case "2":
                    listObject.ListGoalsWithVisualFeedback(p._cjbListOfGoals);
                    break;

                case "3":
                    p.SaveGoalsViaInput(p._cjbListOfGoals);
                    break;

                case "4":
                    Console.WriteLine("Enter the filename to load goals:");
                    p.fileName = Console.ReadLine();
                    p.LoadGoalsFromFile();
                    break;

                case "5":
                    listObject.ListGoalsFromRecord(p._cjbListOfGoals, p);
                    break;

                case "6":
                    Console.WriteLine("Bye!");
                    done = true;
                    break;

                default:
                    Console.WriteLine("Please enter a valid option.");
                    break;
            }
        }
    }
}