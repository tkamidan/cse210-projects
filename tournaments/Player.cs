public class Player {
    private string _name;
    private string _position = "";
    private int _jerseyNumber;

    public Player(string name, int jerseyNumber) {
        _name = name;
        _jerseyNumber = jerseyNumber;
    }

    public Player(string name, int jerseyNumber, string position){
        _name = name;
        _position = position;
        _jerseyNumber = jerseyNumber;
    }

    public void SetPosition(string position) {
        _position = position;
    }

    public void DisplayPlayer() {
        Console.WriteLine($"{_name}: {_position} {_jerseyNumber}");
    }

    
}