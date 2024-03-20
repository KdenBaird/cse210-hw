using System;
using System.ComponentModel.Design;

class Program
{
    
    static void Main(string[] args)
    {
        // CBWord wordObj = new CBWord();
        // wordObj.SetWord("test1");
        // string wordString = wordObj.GetWord();


        CBScripture scrip = new CBScripture();

        bool done = false;
        while (done == false)
        {
        scrip.Menu();
        string input = Console.ReadLine();
        
        //Pick Random Scripture
        if (input == "1")
            {
                scrip.ChooseRandomScripture();
            }
        
        else if (input == "2")
            {
                scrip.ScriptureMemorizer();
            }
        
        
        //Quit Program
        else if (input == "quit")
            {
                Console.Write("Bye!");
                done = true;
            }
        //Error handling asks user to enter valid numb
        else
            {
                Console.WriteLine("Please enter either 1, 2 or 'quit'. ");
                scrip.Menu();
            }
        }
    }
}