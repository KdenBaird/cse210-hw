using System;

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
