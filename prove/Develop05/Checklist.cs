public class Checklist : Goal {

    private int _timesNeeded;
    private int _bonusPoints;
    public Checklist() {

    }
    public Checklist(string name, string description, int points, int timesCompleted, int timesNeeded, int bonusPoints) : base(name, description, points, timesCompleted) {
        _timesNeeded = timesNeeded;
        _bonusPoints = bonusPoints;
    }
    public override void Display()
    {
        base.Display();
        Console.WriteLine($"This is a Checklist Goal. You can only complete it the number of times that you set it as at the beginning. \nYou have completed this goal {_timesCompleted}/{_timesNeeded} times. If you complete the goal, you will get {_bonusPoints} bonus points!");
    }
    public override void SetGoal()
    {
        base.SetGoal();
        Console.Write("How many times is needed to complete the goal? ");
        _timesNeeded = int.Parse(Console.ReadLine());
        Console.Write("How many bonus points should this have after completed? ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }
    public override string SaveLine()
    {
        return $"Checklist|{GetName()}|{GetDescription()}|{GetPoints()}|{GetTimesCompleted()}|{_timesNeeded}|{_bonusPoints}";
    }

    public int GetTimesNeeded() {
        return _timesNeeded;
    }

    public override int Calculate()
    {
        int baseCalculation = base.Calculate();
        if (_timesCompleted >= _timesNeeded) {
            baseCalculation += _bonusPoints;
        }
        return baseCalculation;
    }
}