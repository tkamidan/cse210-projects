using System;

public class Entry
{
    public string _pmt;
    public string _date;
    public string _time;
    public string _location;
    public string _emotion;
    public string _title;
    public string _text;

    public Entry(string location, string emotion, string title = "", string text = "", string prompt = "", string date = "", string time = "")
    {
        Prompt pmt = new Prompt();

        if (string.IsNullOrEmpty(prompt))
        {
            _pmt = pmt.GetRandomPrompt();
        }
        else
        {
            _pmt = prompt;
        }

        if (string.IsNullOrEmpty(date) && string.IsNullOrEmpty(time))
        {
            DateTime currentDateTime = DateTime.Now;
            _date = currentDateTime.ToString("MMMM dd, yyyy");
            _time = currentDateTime.ToString("hh:mm:ss tt");
        }
        else
        {
            _date = date;
            _time = time;
        }

        _location = location;
        _emotion = emotion;
        _title = title;
        _text = text;
    }

    public void Display()
    {
        Console.WriteLine(_date);
        Console.WriteLine(_time);
        Console.WriteLine(_location);
        Console.WriteLine();
        Console.WriteLine(_pmt);
        Console.WriteLine($"Today I am feeling {_emotion}!");
        Console.WriteLine();
        string line = "------------------------------------------------------------------------------------------";
        Console.WriteLine(line);
        Console.WriteLine(_title);
        Console.WriteLine();
        Console.WriteLine(_text);
        Console.WriteLine(line);
    }

    public string GetPrompt()
    {
        return _pmt;
    }
}