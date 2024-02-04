using System.ComponentModel.DataAnnotations;
using System.IO;
public class Journal
{
    public List <Entry> entries = new List<Entry>();
     void Menu()
    {
        Console.WriteLine("1: New Entry: ");
        Console.WriteLine("2: Display Entries: ");
        Console.WriteLine("3: Save :");
        Console.WriteLine("4: Load: ");
        Console.WriteLine("5: Exit: ");
        Console.Write("Choose Option (1-5): ");
    }
//study this to understand how objects work.
     void GetEntry(Journal jobject)
    {
        Entry entryObject = new Entry();
        entryObject._prompt = entryObject.DisplayPrompt();
        Console.WriteLine(entryObject._prompt);
        entryObject._date = DateTime.Now.ToString("MM-dd-yyyy HH:mm");
        entryObject._input = entryObject.GetUserInput();
        jobject.entries.Add(entryObject);
        
    }
//study this to understand hwo parameters get passed in, and how objects work. 
     void Display(Journal jobject)
    {
        foreach (Entry entries in jobject.entries) 
        {
            Console.WriteLine($"{entries._prompt}");
            Console.WriteLine($"{entries._date}");
            Console.WriteLine($"{entries._input}");
        }
    }
     void Save(Journal jobject)
    {

        Console.Write("Enter a filename: ");
        string fileName = Console.ReadLine(); 
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entries in jobject.entries)
            {
                outputFile.WriteLine($"{entries._prompt}");
                outputFile.WriteLine($"{entries._date}");
                outputFile.WriteLine($"{entries._input}");
            }

        }
    }

    void Load(Journal jobject)
    {

        Console.Write("Enter a filename: ");
        string fileName = Console.ReadLine();
        using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
    
    }

    static void Main(string[] args)
    {
        Journal journal = new Journal();
        while (true)
        {
        journal.Menu();        
        string input = Console.ReadLine();
            if (input == "1")
            {
                journal.GetEntry(journal);
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
