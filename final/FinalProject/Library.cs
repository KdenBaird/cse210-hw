public class CBLibrary
{
    // Attributes
    private List<CBBook> _cjbBooks;
    private List<CBMember> _cjbMembers;
    private List<CBDVD> _cjbDVDs;

    // Constructors
    public CBLibrary()
    {
        _cjbBooks = new List<CBBook>();
        _cjbMembers = new List<CBMember>();
        _cjbDVDs = new List<CBDVD>();
    }
    public CBLibrary(List<CBMember> members)
    {
        _cjbBooks = new List<CBBook>();
        _cjbMembers = members; // Initialize the members list with the provided list
        _cjbDVDs = new List<CBDVD>();
    }

    // Methods
    public void CBAddBook(CBBook book)
    {
        _cjbBooks.Add(book);
    }
    public void CBAddDVD(CBDVD dvd)
    {
        _cjbDVDs.Add(dvd);
    }
    public List<CBBook> CBGetBooks()
    {
        return _cjbBooks;
    }
    public List<CBDVD> CBGetDVDs()
    {
        return _cjbDVDs;
    }
    public void CBSetBooks(List<CBBook> booklist)
    {
        _cjbBooks = booklist;
    }
    public void SetCjbDVDs(List<CBDVD> listOfDvds)
    {
        _cjbDVDs = listOfDvds;
    }

    public void CBDisplayAvailableBooks()
    {
        Console.WriteLine("");
        foreach (CBBook book in _cjbBooks)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, ISBN: {book.Isbn}, Available: {book.Availability}");
        }
        Console.WriteLine("");
    }

    public void CBDisplayAvailableDVDs()
    {
        Console.WriteLine("");
        foreach (CBDVD dvd in _cjbDVDs)
        {
            Console.WriteLine($"Title: {dvd.Title}, Director: {dvd.Director}, Duration: {dvd.Duration}, Availability: {dvd.Availability} ");
        }
        Console.WriteLine("");
    }

    public CBBook FindBookByISBN(string isbn)
    {
        foreach (CBBook book in _cjbBooks)
        {
            if (book.Isbn == isbn)
            {
                return book;
            }
        }
        return null; // Book not found
    }

    
    public void CheckoutBook(string isbn)
    {
        CBBook bookToCheckout = _cjbBooks.Find(book => book.Isbn == isbn);

        if (bookToCheckout != null)
        {
            bookToCheckout.CBCheckoutBook();
        }
        else
        {
            Console.WriteLine("Book not found.");
        }
    }
    /*public void CBReturnBook(string isbn)
    {
        if (isbn is CBBook book)
        {
            book.CBReturnBookItem();
            // Update availability
            // For example, assuming _cjbBooks is a list of CBBook objects
            CBBook returnedBook = (CBBook)item;
            returnedBook.SetAvailability(true); // Set book as available again
        }
        else
        {
            Console.WriteLine("Cannot return a non-book item.");
        }
    } */
    public void CBReturnBook(string isbn)
    {
    // Find the book with the specified ISBN
    CBBook bookToReturn = _cjbBooks.Find(book => book.Isbn == isbn);

    if (bookToReturn != null)
    {
        if (!bookToReturn.Availability)
        {
            
            bookToReturn.SetAvailability(true);
            Console.WriteLine($"Book with ISBN {isbn} returned successfully.");
        }
        else    
        {
            Console.WriteLine($"Book with ISBN {isbn} is already available.");
        }
    }
    else
    {
        Console.WriteLine("Book not found.");
    }
    }

}
