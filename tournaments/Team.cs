public class Team {
    private List<Player> _players = new List<Player>();
    private string _name="";
    private int _wins = 0;
    private int _losses = 0;
    
    public Team(string name) {
        _name = name;
    }

    public void AddPlayer(Player p) {
        _players.Add(p);
    }

    public void DisplayRoster(){
        Console.WriteLine($"{_name}");
        Console.WriteLine($"Wins: {_wins} Losses: {_losses}");
        foreach (Player player in _players) {
            player.DisplayPlayer();
        }
    }

    public void AddWin(int wins = 1){
        _wins += wins;
    }

    public void AddLoss(int losses = 1){
        _losses += losses;
    }
}