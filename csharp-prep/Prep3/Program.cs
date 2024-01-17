using System;
using System.ComponentModel;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        //Part2:
        //Console.Write("What is the magic number? ");
        //int magicNumber = int.Parse(Console.ReadLine());
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        int guess = -1;

       while (guess != magicNumber)
       {
        Console.Write("What is your guess?");
         guess = int.Parse(Console.ReadLine());

        if (guess < magicNumber)
            {
            Console.WriteLine("Higher");
            
            }
        else if (guess > magicNumber) {
            Console.WriteLine("Lower");
            }
        else 
            {
            Console.WriteLine("You guessed it! ");
            }
       }
    }
}