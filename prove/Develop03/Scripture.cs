using System;

class CBScripture
{
    //Attributes
    private string _cjbpassage;
    private string _cjbreference;
    
    //Constructors
    CBScripture scripture = new(string _reference);

    CBScripture scripture1 = new();

    public void DisplayScripture()
    {
        Console.WriteLine(CBScripture.ToString);
    }
    
    public void ChooseRandomScripture()
    {
        
    }

    public void AddScripture()
    {
        //call another function?
    }

    //void return type?
    static void ToString() 
    {

    }
    // does every method need an identifier?
    public string HideScripture()
    {

    }
    public void Menu()
    {
        Console.WriteLine("1: Pick a scripture to display: ");
        Console.WriteLine("2: Display a random scripture: ");
        Console.WriteLine("3: Add Scripture: ");
        Console.WriteLine("Quit Program:");
    }
}