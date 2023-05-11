using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        journal.NewEntry();
        journal.NewEntry();
        journal.SaveJournal("journal.txt");
    }
}