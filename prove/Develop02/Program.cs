class Program
{
    static void GetEntry(CBJournal jobject, CBPrompt p)
        {
        CBEntry entryObject = new CBEntry();
        entryObject._cjbprompt = entryObject.DisplayPrompt(p);
        Console.WriteLine(entryObject._cjbprompt);
        entryObject._cjbdate = DateTime.Now.ToString("MM-dd-yyyy HH:mm");
        entryObject._cjbinput = entryObject.GetUserInput();
        jobject.entries.Add(entryObject);
        
    }
    static void Main(string[] args)
    {
        CBJournal journal = new CBJournal();
        CBPrompt p = new CBPrompt();

        while (true)
        {
        journal.Menu();        
        string input = Console.ReadLine();
            if (input == "1")
            {
                GetEntry(journal, p);
            }
            else if (input == "2")
            {
                journal.Display(journal);
            }
           else if (input == "3")
            {
                journal.Save(journal);
            }
            else if (input == "4")
            {
                journal.Load(journal);
            }
            else if (input == "5")
            {
                Console.Write("Bye");
                break;
            }
        }
    }
}
