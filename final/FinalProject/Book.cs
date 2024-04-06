using System;
using Microsoft.VisualBasic;

public class CBBook : CBLibraryItem
{
    // Additional attributes specific to Book
    private string _cjbAuthor;
    private string _cjbGenre;
    private string _cjbIsbn;

    // Constructor
    public CBBook(string title, string author, string genre, string isbn, bool availability)
        : base(title, availability)
    {
        _cjbAuthor = author;
        _cjbGenre = genre;
        _cjbIsbn = isbn;
    }
    
     // Public properties to access the private fields
     // (Chat GPT helped me in creating these public properties)
     // public string Author: This declares a public property named Author, which returns a string.
     // This is called the expression body arrow. It's a syntactic shortcut used to define a read-only property. It's equivalent to writing { get { return _cjbAuthor; } }.
     // cjbAuthor: This is the value that the Author property will return. It accesses the private field _cjbAuthor within the class.
     // Notes: Read-only properties in C# are properties that can only be read, not written. Once set, their values cannot be changed. They are useful when you want 
     // to expose a property publicly but prevent external code from modifying its value after it has been initialized.
    public string Author => _cjbAuthor;
    public string Genre => _cjbGenre;
    public string Isbn => _cjbIsbn;
    public string Title => _cjbTitle;
    public bool Availability => _cjbAvailability;

    // Methods
    public override void CBCheckOut()
    {
        // Implementation for checking out a book
        base.CBCheckOut(); // Optionally call base class method
    }

    public override void CBReturn()
    {
        // Implementation for returning a book
        base.CBReturn(); // Optionally call base class method
    }

    public override void CBDisplayDetails()
    {
    base.CBDisplayDetails(); // Call base class implementation first
    Console.WriteLine($"Author: {_cjbAuthor}");
    Console.WriteLine($"ISBN: {_cjbIsbn}");
    Console.WriteLine($"Genre: {_cjbGenre}");
    }
}
