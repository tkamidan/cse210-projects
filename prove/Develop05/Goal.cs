public abstract class Goal {
    private string _name;
    private string _description;
    private int _points;
    protected int _timesCompleted = 0;
    public Goal(){

    }
    public Goal(string name, string description, int points) {
        _name = name;
        _description = description;
        _points = points;
    }

    public Goal(string name, string description, int points, int timesCompleted) {
        _name = name;
        _description = description;
        _points = points;
        _timesCompleted = timesCompleted;
    }

    public virtual void Display() {
        Console.WriteLine($"This goal is named {_name} and is worth {_points} points. \n{_description}");
    }
    public virtual void SetGoal() {
        Console.Write("What is the name of this goal? ");
        string name = Console.ReadLine();
        _name = name;
        Console.Write("What is the description of this goal? ");
        string description = Console.ReadLine();
        _description = description;
        Console.Write("How many points should this goal be? ");
        int points = int.Parse(Console.ReadLine());
        _points = points;
    }
    public virtual void Complete(int times = 1) {
        _timesCompleted += 1;
    }

    public int GetTimesCompleted() {
        return _timesCompleted;
    }

    public string GetName() {
        return _name;
    }

    public string GetDescription() {
        return _description;
    }

    public int GetPoints() {
        return _points;
    }

    public virtual int Calculate() {
        return _points * _timesCompleted;
    }

    public abstract string SaveLine();
}