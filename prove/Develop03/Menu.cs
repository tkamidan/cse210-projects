public class Menu {
    private List<Scripture> _scriptures = new List<Scripture>();
    
    public Menu() {
        Load();
    }
    public void DisplayMainMenu() {
        int choice = 0;
        while (choice != 4) {
            Console.Clear();
            Console.WriteLine("Welcome to the Scripture Memorizer!");
            Console.WriteLine();
            Console.WriteLine("Options:");
            Console.WriteLine("1. Memorize a Random Scripture");
            Console.WriteLine("2. See List of Scriptures");
            Console.WriteLine("3. Choose a Scripture to Memorize");
            Console.WriteLine("4. Quit");
            choice = Int32.Parse(Console.ReadLine());

            switch (choice) {
                case 1:
                    Scripture randomScripture = GetRandomScripture();
                    MemorizeScripture(randomScripture);
                    break;
                case 2:
                    ShowScriptures();
                    Console.ReadLine();
                    break;
                case 3:
                    Scripture chosenScripture = ChooseAScripture();
                    MemorizeScripture(chosenScripture);
                    break;
                case 4:
                    Console.WriteLine("Quitting...");
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }
    }


    private void Load() {
        string[] lines = System.IO.File.ReadAllLines("Scriptures.txt");
        int count = 0;
        foreach(string line in lines) {
            string[] attributes = line.Split("|");
            string book = attributes[0];
            string chapterNum = attributes[1];
            string startVerse = attributes[2];
            string endVerse = attributes[3];
            string text = attributes[4];
            if (endVerse == "") {
                int intChapterNum = Int32.Parse(chapterNum);
                int intStartVerse = Int32.Parse(startVerse);
                _scriptures.Add(new Scripture(new Reference(book, intChapterNum, intStartVerse)));
                _scriptures[count].ConvertStringToWords(text);
                
            }
            else {
                int intChapterNum = Int32.Parse(chapterNum);
                int intStartVerse = Int32.Parse(startVerse);
                int intEndVerse = Int32.Parse(endVerse);
                _scriptures.Add(new Scripture(new Reference(book, intChapterNum, intStartVerse, intEndVerse)));
                _scriptures[count].ConvertStringToWords(text);
            }
            count += 1;
        }
    }
    
    private Scripture GetRandomScripture() {
        var random = new Random();
        var randomNumber = random.Next(_scriptures.Count);
        return _scriptures[randomNumber];
    }

    private void ShowMemorizeScriptureItems() {
        Console.WriteLine("Press Enter: Hide 1 Word");
        Console.WriteLine("1: Hide Certain Amount of Random Words");
        Console.WriteLine("2: Restart");
        Console.WriteLine("Type \"quit\": Quit the Program");
    }

    private void MemorizeScripture(Scripture scripture) {
        int wordCount = scripture.GetWordCount();
        int wordsHidden = 0;
        while (wordsHidden < wordCount) {
            Console.Clear();
            scripture.Display();
            Console.WriteLine();
            ShowMemorizeScriptureItems();
            string memorizeDecision = Console.ReadLine();
            
            switch (memorizeDecision) {
                case null:
                    scripture.HideRandomWord();
                    wordsHidden += 1;
                    break;
                case "1":
                    Console.Write("What number of words should the program hide? ");
                    int numOfWords = Int32.Parse(Console.ReadLine());
                    scripture.HideRandomWord(numOfWords);
                    wordsHidden += numOfWords;
                    break;
                case "2":
                    scripture.ShowAllWords();
                    wordsHidden = 0;
                    break;
                case "quit":
                    Console.WriteLine("Quitting...");
                    Environment.Exit(0);
                    break;
                default:
                    scripture.HideRandomWord();
                    wordsHidden += 1;
                    break;
            }
        }

        Console.Clear();
        scripture.Display();
        Console.WriteLine();
        Console.WriteLine("Press Enter");
        Console.ReadLine();
        Console.WriteLine("Congrats, you memorized the whole scripture!");
        Console.WriteLine("Quitting...");
        Environment.Exit(0);
    }
    
    private void ShowScriptures() {
        Console.Clear();
        int indexNumber = 0;
        foreach (Scripture scripture in _scriptures) {
            Console.WriteLine();
            Console.WriteLine($"{indexNumber}:");
            scripture.Display();
            indexNumber += 1;
        }
    }

    private Scripture ChooseAScripture() {
        ShowScriptures();
        Console.WriteLine();
        Console.Write("Which scripture do you want to pick? ");
        int scriptureNum = Int32.Parse(Console.ReadLine());
        return _scriptures[scriptureNum];
    }
}