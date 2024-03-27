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
        // ask what the purpose of these constructors are? Are they to be able to call things in that class?
        CBProgram p = new();
        
        bool done = false;
        while (done == false)
        {
            //Ask about this error
            p.DisplayMenu();
            string input = Console.ReadLine();

            if (input == "1")
                {
                    Console.WriteLine("\nHow long do you want your duration to be for the breathing activity?");
                    float userDuration = float.Parse(Console.ReadLine());
                    CBBreathing b = new CBBreathing(userDuration);
                }

            else if (input == "2")
                {
                    Console.WriteLine("\nHow long do you want your duration to be for the reflection activity?");
                    float userDuration = float.Parse(Console.ReadLine());
                    CBReflection r = new CBReflection(userDuration);
                }

            else if (input == "3")
                {
                    Console.WriteLine("\nHow long do you want your duration to be for the reflection activity?");
                    float userDuration = float.Parse(Console.ReadLine());
                    CBListing l = new CBListing(userDuration);   
                }

            else
                {
                    Console.WriteLine("Bye!");
                    done = true;
                }
        }
    }
}