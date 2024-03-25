using System;

class CBProgram
{
    
    public void DisplayMenu()
    {
        Console.WriteLine("1: Type '1' for the Breathing Activity: ");
        Console.WriteLine("2: Type '2' for the Reflection Activity: ");
        Console.WriteLine("3: Type '3' for the Listing Activity: ");
        Console.WriteLine("4: Type '4' to quit program: ");

    }

    static void Main(string[] args)
    {
        CBProgram p = new CBProgram();

        bool done = false;
        while (done == false)
        {
            //Ask about this error
            p.DisplayMenu();
            string input = Console.ReadLine();

            if (input == "1")
                {
                    CBBreathing.Run();
                }

            else if (input == "2")
                {
                    CBReflection.Run();
                }

            else if (input == "3")
                {
                    CBListing.Run();
                }

            else
                {
                    Console.WriteLine("Bye!");
                    done = true;
                }


            
        }
    }
}