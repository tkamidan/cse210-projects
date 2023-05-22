// See https://aka.ms/new-console-template for more information
Player neymar = new Player("Neymar jr.", 10, "Forward");
Player kobe = new Player("Kobe Bryant", 24);

kobe.SetPosition("Shooting Guard");

Team team = new Team("Awesome Sauce");
team.AddPlayer(neymar);
team.AddPlayer(kobe);

team.AddWin();
team.AddLoss();

team.DisplayRoster();



