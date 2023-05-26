public class Reference {
    private string _book;
    private int _chapterNum;
    private int _startVerse;
    private int? _endVerse;

    public Reference(string book, int chapterNum, int startVerse, int endVerse) {
        _book = book;
        _chapterNum = chapterNum;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public Reference(string book, int chapterNum, int startVerse) {
        _book = book;
        _chapterNum = chapterNum;
        _startVerse = startVerse;
    }

    public void Display() {
        if (_endVerse == null) {
            Console.WriteLine($"{_book} {_chapterNum}:{_startVerse}");
        }
        else {
            Console.WriteLine($"{_book} {_chapterNum}:{_startVerse}-{_endVerse}");
        }
    }
}