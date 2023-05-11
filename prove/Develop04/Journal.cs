using System.IO; 

public class Journal {
    public List<Entry> _entries;


    public Journal() {

    }

    public void ShowAllEntries() {
        foreach (Entry entry in _entries) {
            entry.Display();
        }
    }

    public void NewEntry() {
        Console.Write("Where are you writing this entry from? ");
        string location = Console.ReadLine();
        Console.Write("How are you feeling right now? ");
        string emotion = Console.ReadLine();
        Entry newEntry = new Entry(location, emotion);
        Console.WriteLine($"The prompt is: {newEntry.pmt}");
        Console.WriteLine("Please type in your response:");
        string response = Console.ReadLine();
        newEntry._text = response;
        Console.WriteLine("What should the title be for this response? ");
        string title = Console.ReadLine();
        newEntry._title = title;
        _entries.Add(newEntry);
        Console.WriteLine("Entry complete!");
    }

    public void LoadJournal(string fileName) {
        
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines) {
            string[] attributes = line.Split("|");
            string prompt = attributes[0];
            string date = attributes[1];
            string time = attributes[2];
            string location = attributes[3];
            string emotion = attributes[4];
            string title = attributes[5];
            string text = attributes[6];
            _entries.Add(new Entry(location, emotion, title, text, prompt, date, time));
        }
            
    }

    public void SaveJournal(string fileName) {
        using (StreamWriter outputfile = new StreamWriter(fileName)) {
            foreach (Entry entry in _entries) {
                outputfile.WriteLine($"{entry.pmt}|{entry._date}|{entry._time}|{entry._location}|{entry._emotion}|{entry._title}|{entry._text}");
            }
        }
    }
}