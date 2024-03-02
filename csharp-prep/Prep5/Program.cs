using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();
        string userName = UserName();
        int userNumber = UserNumber();
        int squareNumber = SquareNumber(userNumber);
         DisplayResult(userName, squareNumber);

        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the Program! ");
        }
        
        
        static string UserName()
        {
            Console.Write("Please enter your name: ");
            string name =  Console.ReadLine();
            
            return name;
        }

        static int UserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());

            return number;
        }
        
        static int SquareNumber(int number)
        {
            int squareNumber = number * number;

            return squareNumber;
        }
        static void DisplayResult(string name, int number)
        {
            Console.Write($"{name}, the square of your number is {number}! ");
        }
    }
}