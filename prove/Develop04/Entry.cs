public class Entry {
    
    Prompt _pmt = new Prompt();
    public string pmt;
    public string _date;
    public string _time;
    public string _location;
    public string _emotion;
    public string _title;
    public string _text;


    public Entry(string location, string emotion, string title = "", string text = "", string prompt = "", string date = "", string time = "")
    {
        if (prompt == "") {
            pmt = _pmt.GetRandomPrompt();
        } else {
            pmt = prompt;
        }
        if (date == "" && time == "") {
            DateTime currentDateTime = DateTime.Now;
            string _date = currentDateTime.ToString("MMMM dd, yyyy");
            string _time = currentDateTime.ToString("hh:mm:ss tt");
        } else {
            _date = date;
            _time = time;
        }
        _location = location;
        _emotion = emotion;
        _title = title;
        _text = text;
    }

    public void Display(){
        Console.Write(_date);
        Console.WriteLine(_time);
        Console.WriteLine(_location);
        Console.WriteLine();
        Console.WriteLine(pmt);
        Console.WriteLine($"Today I am feeling {_emotion}!");
        Console.WriteLine();
        string line = "------------------------------------------------------------------------------------------";
        Console.WriteLine(line);
        Console.WriteLine(_title);
        Console.WriteLine();
        Console.WriteLine(_text);
        Console.WriteLine(line);
    }

    public string GetPrompt() {
        return pmt;
    }
}