using System;

public class CBLibraryItem
{
    // Attributes
    protected string _cjbTitle;
    protected bool _cjbAvailability;

    // Constructor
    public CBLibraryItem(string title = "", bool availability = false)
    {
        _cjbTitle = title;
        _cjbAvailability = availability;
    }

    // Methods
    public virtual void CBCheckOut()
    {
        // Implementation for checking out a library item
    }

    public virtual void CBReturn()
    {
        // Implementation for returning a library item
    }

    public virtual void CBDisplayDetails()
    {
    Console.WriteLine($"Title: {_cjbTitle}");
    Console.WriteLine($"Availability: {(_cjbAvailability ? "Available" : "Checked out")}");
    }
}
