using System.ComponentModel.DataAnnotations;
using System.IO;
public class CBJournal
{
    public List <CBEntry> entries = new List<CBEntry>();
     public void Menu()
    {
        Console.WriteLine("1: New Entry: ");
        Console.WriteLine("2: Display Entries: ");
        Console.WriteLine("3: Save :");
        Console.WriteLine("4: Load: ");
        Console.WriteLine("5: Exit: ");
        Console.Write("Choose Option (1-5): ");
    }
//study this to understand how objects work.
      
//study this to understand how parameters get passed in, and how objects work. 
     public void Display(CBJournal jobject)
    {
        foreach (CBEntry entries in jobject.entries) 
        {
            Console.WriteLine($"{entries._cjbprompt}");
            Console.WriteLine($"{entries._cjbdate}");
            Console.WriteLine($"{entries._cjbinput}");
        }
    }
     public void Save(CBJournal jobject)
    {
        Console.Write("Enter a filename: ");
        string fileName = Console.ReadLine(); 
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (CBEntry entries in jobject.entries)
            {
                outputFile.WriteLine($"{entries._cjbprompt} || {entries._cjbdate} || {entries._cjbinput}");
            }
        }
    }

    public void Load(CBJournal jobject)
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

}