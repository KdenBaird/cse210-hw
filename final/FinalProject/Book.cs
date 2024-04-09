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

    public CBBook()
    {
        
    }

    public void CBCheckoutBook()
    {
        // Check if the book is available
        if (Availability)
        {
            // Set the availability to false, indicating the book is checked out
            SetAvailability(false);
            Console.WriteLine($"Book '{Title}' checked out successfully!\n");
        }
        else
        {
            Console.WriteLine("Book is already checked out.");
        }

    }
    protected override void CBReturnItem()
    {
        CBLibrary libObject = new();
        Console.WriteLine("Please enter the ISBN of the book you would like to return: ");
        string userInput = Console.ReadLine();
        CBBook bookToReturn = libObject.FindBookByISBN(userInput);

        if (bookToReturn != null && !bookToReturn.Availability)
        {
        // Book found and it's checked out
        Console.WriteLine("Returning the book...");
        // Update the book's availability
        bookToReturn.SetAvailability(true);
        Console.WriteLine("Book returned successfully.");
        }
    else if (bookToReturn != null && bookToReturn.Availability)
        {
        // Book found but it's already available
        Console.WriteLine("This book is not checked out.");
        }
    else
        {
        // Book not found
        Console.WriteLine("Book not found.");
        }
    }
    public void CBReturnBookItem()
    {
        CBReturnItem();
    }
}

   /* public override void CBReturn()
    {
        // Implementation for returning a book
        base.CBReturn(); // Optionally call base class method
    }
    */

   /* public override void CBDisplayDetails()
    {
    base.CBDisplayDetails(); // Call base class implementation first
    Console.WriteLine($"Author: {_cjbAuthor}");
    Console.WriteLine($"ISBN: {_cjbIsbn}");
    Console.WriteLine($"Genre: {_cjbGenre}");
    }
    */

