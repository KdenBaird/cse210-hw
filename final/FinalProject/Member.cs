using System;

public class CBMember
{
    // Attributes
    private string _cjbName;
    private string _cjbId;
    private string _cjbEmail;

    // Constructor
    public CBMember(string name, string id, string email)
    {
        _cjbName = name;
        _cjbId = id;
        _cjbEmail = email;
    }

    // Methods
    public void CBBorrowBook()
    {
        // Implementation for borrowing a book
    }

    public void CBReturnBook()
    {
        // Implementation for returning a book
    }

    public void CBDisplayBorrowedBooks()
    {
        // Implementation for displaying borrowed books
    }
}
