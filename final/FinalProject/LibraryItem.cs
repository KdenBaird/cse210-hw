public class CBLibraryItem
{
    // Attributes
    protected string _cjbTitle;
    protected bool _cjbAvailability;

    // Constructor
    public CBLibraryItem()
    {

    }
    public CBLibraryItem(string title = "", bool availability = false)
    {
        _cjbTitle = title;
        _cjbAvailability = availability;
    }

    // Methods
    public virtual void CBCheckOut(CBLibrary libObject, List<CBMember> members)
    {
        while (true)
        {
            Console.WriteLine("Would you like to checkout a book or a DVD? (Type '1' for book and '2' for DVD) ");
            string input = Console.ReadLine();

            switch (input)
            {

                // Checkout book
                case "1":
                    Console.WriteLine("Enter your email: ");
                    string email = Console.ReadLine().Trim();

                    // Check if the provided email is associated with a member
                    bool isMember = false;
                    foreach (CBMember member in members)
                    {

                        if (member.GetEmail() == email)
                        {
                            isMember = true;
                            break;
                        }
                    }
                    if (isMember)
                    {
                        libObject.CBDisplayAvailableBooks();
                        Console.WriteLine("Enter the ISBN of the book you want to check out: ");
                        string isbn = Console.ReadLine();
                        CBBook bookToCheckout = libObject.FindBookByISBN(isbn);
                        if (bookToCheckout != null)
                        {
                            bookToCheckout.CBCheckoutBook(); // Checkout the found book
                        }
                        else
                        {
                            Console.WriteLine("Book not found.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Member not found.");
                    }
                    break;
                // Checkout DVD
                case "2":
                    libObject.CBDisplayAvailableDVDs();
                    return;
                // Invalid entry
                default:
                    Console.WriteLine("Please enter either '1' or '2' ");
                    break;
            }
                Console.WriteLine("Do you want to check out another book or another DVD? (Type 'yes' to continue or any other key to return to the main menu)");
                string continueInput = Console.ReadLine().ToLower();
                if (continueInput != "yes")
                {
                    break; // Exit the loop and return to the main menu
                }
            }
        }
    protected virtual void CBReturnItem()
    {
    Console.WriteLine("Returning the library item...");
    // Implement return logic specific to each subclass
    }

    protected virtual void CBReturn()
    {
        Console.WriteLine("Returning the item...");
    }

    public void SetAvailability(bool available)
    {
        _cjbAvailability = available;
    }
    public virtual void CBDisplayDetails()
    {
        Console.WriteLine($"Title: {_cjbTitle}");
        Console.WriteLine($"Availability: {(_cjbAvailability ? "Available" : "Checked out")}");
    }
}
