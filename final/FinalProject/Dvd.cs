using System;

public class CBDVD : CBLibraryItem
{
    // Additional attributes specific to DVD
    private string _cjbDirector;
    private int _cjbDuration; // Duration in minutes

    // Constructor
    public CBDVD(string title, string director, int duration, bool availability)
        : base(title, availability)
    {
        _cjbDirector = director;
        _cjbDuration = duration;
    }

    // Methods
    public override void CBCheckOut()
    {
        // Implementation for checking out a DVD
        base.CBCheckOut(); // Optionally call base class method
    }

    public override void CBReturn()
    {
        // Implementation for returning a DVD
        base.CBReturn(); // Optionally call base class method
    }

    public override void CBDisplayDetails()
    {
    base.CBDisplayDetails(); // Call base class implementation first
    Console.WriteLine($"Director: {_cjbDirector}");
    Console.WriteLine($"Duration: {_cjbDuration} minutes");
    }

}
