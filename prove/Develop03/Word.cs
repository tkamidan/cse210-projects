public class Word {
    private string _word;
    private Boolean _shown = true;

    public Word(string word) {
        _word = word;
    }

    public void Display() {
        if (_shown == true) {
            Console.Write(_word);
        }
        else if (_shown == false) {
            Console.Write("____");
        }
        Console.Write(" ");
    }

    public void HideWord() {
        _shown = false;
    }

    public void ShowWord() {
        _shown = true;
    }

    public Boolean IsShown() {
        return _shown;
    }
}