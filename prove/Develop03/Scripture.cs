public class Scripture {
    private List<Word> _words = new List<Word>();
    private Reference _reference;

    public Scripture(Reference reference) {
        _reference = reference;
    }

    public void ConvertStringToWords(string text) {
        string[] words = text.Split(" ");

        foreach (string value in words) {
            Word word = new Word(value);
            _words.Add(word);
        }
    }

    public void Display() {
        _reference.Display();
        foreach (Word word in _words) {
            word.Display();
        }
        Console.WriteLine();
    }

    public void HideRandomWord(int num = 1) {
        int count = _words.Count;
        int hiddenCount = 0;

        var random = new Random();

        while (hiddenCount < num && hiddenCount < count) {
            int randomNumber = random.Next(count);
            if (_words[randomNumber].IsShown()) {
                _words[randomNumber].HideWord();
                hiddenCount++;
            }
    }
    }

    public int GetWordCount() {
        return _words.Count;
    }

    public void ShowAllWords() {
        foreach (Word word in _words) {
            word.ShowWord();
        }
    }
        
}
