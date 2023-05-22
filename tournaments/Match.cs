public class Match {
    private Team _winningTeam;
    private Team _lossingTeam;

    public Match(Team winningTeam, Team losingTeam){
        _winningTeam = winningTeam;
        _winningTeam.AddWin();
        _lossingTeam = _lossingTeam;
        _lossingTeam.AddLoss();
    }
}