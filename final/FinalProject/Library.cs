using System.Reflection;

public class CBLibrary 
{
    // Attributes
    private List<CBBook> _cjbBooks;
    private List<CBMember> _cjbMembers;
    private List <CBDVD> _cjbDVDs;
    
    // Constructors
    public CBLibrary() 
    {
        _cjbBooks = new List<CBBook>();
        _cjbMembers = new List<CBMember>();
        _cjbDVDs = new List<CBDVD>();
    }
    public CBDVD dvd = new();
    // Methods
    public void CBAddBook(CBBook book) 
    {
        // Implementation for adding a book to the library
        _cjbBooks.Add(book);
    }
    public void CBAddDVD(CBDVD dvd) 
    {
        _cjbDVDs.Add(dvd);
    }
    public List <CBBook> CBGetBooks()
    {
        return _cjbBooks;
    }
     // Method to get DVDs from the library
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

    public void CBRemoveBook(CBBook book) 
    {
        // Implementation for removing a book from the library
    }

    public void CBAddMember(CBMember member) 
    {
        // Implementation for adding a member to the library
    }

    public void CBRemoveMember(CBMember member) 
    {
        // Implementation for removing a member from the library
    }

    public void CBDisplayAvailableBooks()
    {
        foreach (CBBook book in _cjbBooks)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, ISBN: {book.Isbn}, Available: {book.Availability}");
        }
        
    }

    public void CBDisplayAvailableDVDs() 
    {
        foreach (CBDVD dvd in _cjbDVDs)
        {
            Console.WriteLine($"Title: {dvd.Title}, Director: {dvd.Director}, Duration: {dvd.Duration}, Availability: {dvd.Availability} ");
        }
    }
    
    public void CBDisplayMembers() 
    {
        // Implementation for displaying all members in the library
    }
    public void CBCheckOut()
    {

    }
    /*public void CreateLibrary()
    {

    }
    */
}

