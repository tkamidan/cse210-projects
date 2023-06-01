public class Dvd : Loanable {
    private string _title;

    public Dvd(string title) {
        _title = title;
    }

    public override void Display() {
        base.Display();
        Console.WriteLine($"Title: {_title}");
    }
}