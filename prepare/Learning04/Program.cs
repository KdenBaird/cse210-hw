using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment ass1 = new Assignment("Kden Baird", "Multiplication");
        Console.WriteLine(ass1.GetSummary());

        MathAssignment mathass1 = new MathAssignment("Kden Baird" , "Fractions", "7.3" , "8-19");
        Console.WriteLine(mathass1.GetSummary());
        Console.WriteLine(mathass1.GetHomeworkList());

        WritingAssignment writass1 = new WritingAssignment("Kden Baird", "English", "To Kill A Mockingbird");
        Console.WriteLine(writass1.GetSummary());
        Console.WriteLine(writass1.GetWritingInformation());
    }
}