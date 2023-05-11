using System;

public class Menu
{
    private Journal _journal;

    public Menu()
    {
        _journal = new Journal();
    }

    public void DisplayMainMenu()
    {
        Console.WriteLine("Please select an option:");
        Console.WriteLine("1. Create New Entry");
        Console.WriteLine("2. Show Entries");
        Console.WriteLine("3. Show Random Entry");
        Console.WriteLine("4. Load Journal");
        Console.WriteLine("5. Save Journal");
        Console.WriteLine("6. Exit");
        Console.WriteLine();

        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                CreateNewEntry();
                break;
            case "2":
                ShowEntries();
                break;
            case "3":
                SeeRandomEntry();
                break;
            case "4":
                LoadJournal();
                break;
            case "5":
                SaveJournal();
                break;
            case "6":
                Console.WriteLine("Exiting...");
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }

        Console.WriteLine();
        DisplayMainMenu();
    }

    private void CreateNewEntry()
    {
        Console.WriteLine("Creating a New Entry");
        Console.WriteLine("---------------------");
        Console.WriteLine();

        _journal.NewEntry();
    }

    private void LoadJournal()
    {
        Console.Write("Enter the file name to load: ");
        string fileName = Console.ReadLine();

        _journal.LoadJournal(fileName);
        Console.WriteLine("Journal loaded successfully!");
        Console.WriteLine();
    }

    private void SaveJournal()
    {
        Console.Write("Enter the file name to save: ");
        string fileName = Console.ReadLine();

        _journal.SaveJournal(fileName);
        Console.WriteLine("Journal saved successfully!");
        Console.WriteLine();
    }

    private void ShowEntries() {
        if (_journal._entries == null || _journal._entries.Count == 0) {
            Console.WriteLine("No Entries to be Shown");
        } else {
            Console.WriteLine("Showing Entries for the file:");
            Console.WriteLine();
            _journal.ShowAllEntries();
        }
    }

    private void SeeRandomEntry() {
        _journal.ShowRandomEntry();
    }
}