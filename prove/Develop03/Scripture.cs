using System;
using System.Collections.Generic; 

class CBScripture
{
    //Attributes
    private List<CBWord> _cjbpassage;
    private string _cjbreference;
    private Dictionary<string, List<CBWord>> _scriptures = new Dictionary<string,List<CBWord>>();

    
    //Constructors
    public CBScripture() {
        string fileName = "C:\\Users\\cadem\\OneDrive\\Desktop\\Programming Courses\\Programming with Classes\\cse210-hw\\prove\\Develop03\\scriptures.txt";
        string[] lines = System.IO.File.ReadAllLines(fileName);

        // Split apart each line into a reference and a passsage, then split
        // apart the passage into a list of words, and then save the list of
        // words to a list of lists
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string reference = parts[0];
            string passage = parts[1];

            // Split the passage into a list of word objects
            List<CBWord> words = new List<CBWord>(); // declare words list
            // Split the passage into individual words
            string[] passageSplit = passage.Split(" ");
            // Create a word object for each word in the passage, and put it 
            // in the words list (declared above)
            foreach (string word in passageSplit)
            {
                CBWord newWordObj = new CBWord();
                newWordObj.SetWord(word);
                words.Add(newWordObj);
            }
            _scriptures.Add(reference, words);
        }

    }

    public void ScriptureMemorizer()
    {
        while (true)
        {
            Console.Clear(); // blank slate
            // Display the scripture
            bool wordNotHidden = false;

            Console.WriteLine(_cjbreference);

            foreach (CBWord word in _cjbpassage)
            {
                if (word.GetIsHidden() == false)
                {
                    Console.Write(word.GetWord());
                    wordNotHidden = true;
                }
                else 
                {
                    foreach(char letter in word.GetWord())
                    {
                        Console.Write("_");
                    }
                }
                Console.Write(" ");
            }
            Console.Write("\n \n");

            if (wordNotHidden == true)
            {
                // Prompt user to press any key
                Console.WriteLine("\n\nPress any key to hide a word in the scripture");

                string input = Console.ReadLine();
                if (input != "quit")
                {
                    for (int i = 0; i < 5; i++)
                    {
                        HideWord();
                    }
                }
                else 
                {
                    return;
                }
            }
            else 
            {
                return;
            }
        }   
    }
    
    public void ChooseRandomScripture()
    {
        Random random = new Random();
        int randi = random.Next(_scriptures.Count);
        _cjbreference = _scriptures.Keys.ElementAt(randi);
        _cjbpassage = _scriptures.Values.ElementAt(randi);
    }

 
    //void return type?
    public override string ToString()
    {
        return base.ToString();
    }
    // does every method need an identifier?
    public void HideWord()
    {
        
        Random random = new Random();
        int randi = random.Next(_cjbpassage.Count);
        CBWord word = _cjbpassage[randi];
        word.HideWord();
    }
    public void Menu()
    {
        Console.WriteLine("1: Type '1' first to select a random Scripture to Memorize: ");
        Console.WriteLine("2: Type '2' to display the random scripture: ");
        Console.WriteLine("3: Type 'quit': Quit Program:");
    }
}