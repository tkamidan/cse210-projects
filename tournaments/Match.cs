public class Match {
    private Team _winningTeam;
    private Team _losingTeam;

    public Match(Team winningTeam, Team losingTeam){
        _winningTeam = winningTeam;
        _winningTeam.AddWin();
        _losingTeam = losingTeam;
        _losingTeam.AddLoss();
    }
}