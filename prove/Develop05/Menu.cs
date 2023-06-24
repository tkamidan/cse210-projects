using System.IO;
public class Menu {
    private List<Goal> _goals = new List<Goal>();
    private int _totalPoints = 0;
    public Menu(){

    }
    public void DisplayMainMenu(){
        int decision = 0;
        while (decision != 6) {
            CalculatePoints();
            Console.WriteLine("Welcome to the Goal Tracker!");
            Console.WriteLine($"You have {_totalPoints} points!");
            Console.WriteLine();
            Console.WriteLine("1. Load Save File");
            Console.WriteLine("2. Save To a File");
            Console.WriteLine("3. Create a Goal");
            Console.WriteLine("4. Complete a Goal");
            Console.WriteLine("5. Show All Goals");
            Console.WriteLine("6. Exit");
            Console.WriteLine();
            Console.Write("Enter in your decision: ");
            decision = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch(decision) {
                case 1:
                    Load();
                    break;
                case 2:
                    Save();
                    break;
                case 3:
                    NewGoal();
                    break;
                case 4:
                    CompleteGoal();
                    break;
                case 5:
                    ShowGoals();
                    break;
                case 6:
                    Console.Write("Have you saved (type 0 if yes/type 1 if no)? ");
                    int saveDecision = int.Parse(Console.ReadLine());
                    switch (saveDecision) {
                        case 0:
                            Console.WriteLine("Have a nice day!");
                            break;
                        case 1:
                            Save();
                            break;
                    }
                    break;
            }
        }
    }

    private void Save() {
        Console.Write("What is the name of the file you will be writing too? ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine($"This user has {_totalPoints} points.");

            foreach (Goal goal in _goals) {
                outputFile.WriteLine(goal.SaveLine());
            }
        }
    }

    private void Load() {
        Console.Write("What is the name of the file you want to load? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            if (parts[0] == "Simple") {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool complete = bool.Parse(parts[4]);
                _goals.Add(new Simple(name, description, points, complete));
            }
            else if (parts[0] == "Eternal") {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                int timesCompleted = int.Parse(parts[4]);
                _goals.Add(new Eternal(name, description, points, timesCompleted));
            }
            else if (parts[0] == "Checklist") {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                int timesCompleted = int.Parse(parts[4]);
                int timesNeeded = int.Parse(parts[5]);
                int bonusPoints = int.Parse(parts[6]);
                _goals.Add(new Checklist(name, description, points, timesCompleted, timesNeeded, bonusPoints));
            }
            else if (parts[0] == "Negative") {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                int timesCompleted = int.Parse(parts[4]);
                _goals.Add(new Negative(name, description, points, timesCompleted));
            }
        }

    }
    private void NewGoal() {
        Console.WriteLine("What kind of goal do you want to create?");
        Console.WriteLine();
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("4. Negative Goal");
        Console.WriteLine();
        Console.Write("Enter your decision: ");
        int goalDecision = int.Parse(Console.ReadLine());
        Console.WriteLine();

        switch(goalDecision) {
            case 1:
                Simple simpleGoal = new Simple();
                simpleGoal.SetGoal();
                _goals.Add(simpleGoal);
                break;
            case 2:
                Eternal eternalGoal = new Eternal();
                eternalGoal.SetGoal();
                _goals.Add(eternalGoal);
                break;
            case 3:
                Checklist checklistGoal = new Checklist();
                checklistGoal.SetGoal();
                _goals.Add(checklistGoal);
                break;
            case 4:
                Negative negativeGoal = new Negative();
                negativeGoal.SetGoal();
                _goals.Add(negativeGoal);
                break;
            default:
                Console.WriteLine("Not a valid option. Please try again.");
                break;
        }
    }
    private void CompleteGoal() {
        Console.Write("Which goal do you want to complete? ");
        int completeDecision = int.Parse(Console.ReadLine());

        Goal goal = _goals[completeDecision];
        if (goal is Simple) {
            Simple simpleGoal = goal as Simple;
            if (simpleGoal.GetCompletion()) {
                Console.WriteLine("Goal already complete.");
            }
            else {
                goal.Complete();
            }
        }
        else if (goal is Eternal || goal is Negative) {
            goal.Complete();
        }
        else if (goal is Checklist) {
            Checklist checklistGoal = goal as Checklist;
            if (goal.GetTimesCompleted() == checklistGoal.GetTimesNeeded()) {
                Console.WriteLine("Goal already complete.");
            }
            else {
                goal.Complete();
            }
        }
        
    }

    private void ShowGoals() {
        int indexNumber = 0;
        foreach (Goal goal in _goals) {
            Console.Write($"{indexNumber}. ");
            goal.Display();
            Console.WriteLine();
            indexNumber += 1;
        }
    }

    private void CalculatePoints() {
        if (_goals.Count != 0) {
            int totalPoints = 0;
            foreach (Goal goal in _goals) {
                totalPoints += goal.Calculate();
            }
            _totalPoints = totalPoints;
        }
    }
}

