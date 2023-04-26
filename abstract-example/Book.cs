public class Book
{
    private string _author;
    private string _name;
    private int _timeRead = 0;
    private bool _avaliable = false;

    public Book(string name, string author) 
    {
        _name = name;
        _author = author;
    }

    public void Display()
    {
        Console.WriteLine($"{_name} by {_author}");
        if (!_avaliable) {
            Console.WriteLine("[Checked Out]");
        }
    }

    public bool IsAvaliable()
    {
        return _avaliable;
    }
}