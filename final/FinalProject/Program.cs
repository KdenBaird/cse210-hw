public class CBProgram
{
    public void CreateLibrary(CBLibrary lib, List<CBMember> members)
    {
        lib.CBAddBook(new CBBook("The Catcher in the Rye", "J.D. Salinger", "Fiction", "978-3-16-148460-0", true));
        lib.CBAddBook(new CBBook("The Great Gatsby", "F. Scott Fitzgerald", "Fiction", "978-3-16-148470-0", true));
        lib.CBAddBook(new CBBook("Harry Potter and the Chamber of Secrets", "J.K. Rowling", "Fantasy", "978-3-16-148480-0", true));
        lib.CBAddBook(new CBBook("The Hobbit", "J.R.R. Tolkien", "Fantasy", "978-3-16-148490-0", true));
        lib.CBAddBook(new CBBook("The Da Vinci Code", "Dan Brown", "Mystery", "978-3-16-148500-0", true));

        CBDVD dvd1 = new CBDVD("The Matrix", "Lana Wachowski", 136, true);
        lib.CBAddDVD(dvd1);
        CBDVD dvd2 = new CBDVD("Avatar", "James Cameron", 162, true);
        lib.CBAddDVD(dvd2);
        CBDVD dvd3 = new CBDVD("The Shawshank Redemption", "Frank Darabont", 142, true);
        lib.CBAddDVD(dvd3);
        CBDVD dvd4 = new CBDVD("The Godfather", "Francis Ford Coppola", 175, true);
        lib.CBAddDVD(dvd4);
    }

    public void DisplayMenu()
    {
        Console.WriteLine("Library Management System:");
        Console.WriteLine("1. Display Available Books");
        Console.WriteLine("2. Display Available DVDs");
        Console.WriteLine("3. Check Out a Book");
        Console.WriteLine("4. Become a member");
        Console.WriteLine("5. Return Items");
        Console.WriteLine("6. Return a DVD");
        Console.WriteLine("7. Exit");
    }

    static void Main(string[] args)
    {
        CBLibraryItem libitem = new CBLibraryItem();
        CBProgram p = new CBProgram();
        CBMember m = new CBMember();
        CBLibrary lib = new CBLibrary(m.CjbMemberList);
        CBBook b = new();
        CBDVD d = new();

        p.CreateLibrary(lib, m.CjbMemberList);

        bool done = false;
        while (!done)
        {
            p.DisplayMenu();
            Console.WriteLine("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    lib.CBDisplayAvailableBooks();
                    break;
                case "2":
                    lib.CBDisplayAvailableDVDs();
                    break;
                case "3":
                // Note: must become a member first prior to checking out or returning books.
                    libitem.CBCheckOut(lib, m.CjbMemberList.ToList());
                    break;
                case "4":
                    m.CBAddMember();
                    break;
                case "5":
                    Console.WriteLine("Please type in the ISBN number to return.");
                    string isbnToReturn = Console.ReadLine();
                    lib.CBReturnBook(isbnToReturn);
                    break;
                case "6":
                    d.CBReturnDVDItem();
                    break;
                case "7":
                    Console.WriteLine("Bye!");
                    done = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter an integer 1-7.");
                    break;
            }
        }
    }
}