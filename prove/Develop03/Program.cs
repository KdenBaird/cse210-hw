using System;
using System.ComponentModel.Design;

class Program
{
    
    static void Main(string[] args)
    {
        CBScripture scrip = new CBScripture();

        while (true)
        {
        scrip.Menu();
        string input = Console.ReadLine();
        //Choose Scripture
        if (input == "1")
            {
                scrip.DisplayScripture();
            }
        //Pick Random Scripture
        else if (input == "2")
            {
                scrip.ChooseRandomScripture();
            }
        //Add Scripture
        else if (input == "3")
            {
                scrip.AddScripture();
            }
        //Quit Program
        else if (input == "4")
            {
                Console.Write("Bye!");
                break;
            }
        //Error handling asks user to enter valid numb
        else;
            {
                Console.WriteLine("Please enter either 1, 2, 3, or 4. ");
                scrip.Menu();
            }
        }
    }
}