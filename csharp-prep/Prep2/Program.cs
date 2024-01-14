using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string percent = Console.ReadLine();
        int answer = int.Parse(percent);

        string letter = "";

        if (answer >= 90)
        {
                letter = "A";
        }
        
        else if (answer >= 80)
        {
            letter = "B";
        }

        else if (answer >= 70)
        {
            letter = "C";
        }

        else if (answer >=60)
        {
            letter = "D";
        }

        else 
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (answer >= 70 )
        {
        Console.Write("Congratulations you passed!");
        }

        else 
        {
            Console.WriteLine("You failed. Better luck next time!!");
        }
    }
}