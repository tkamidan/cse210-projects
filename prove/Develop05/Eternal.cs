public class Eternal : Goal {
    public Eternal() {

    }

    public Eternal(string name, string description, int points, int timesCompleted) : base(name, description, points, timesCompleted){

    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"This is an eternal goal. You can complete this goal as many times as you want. \nYou have completed this goal {_timesCompleted} times!");
    }

    public override string SaveLine()
    {
        return $"Eternal|{GetName()}|{GetDescription()}|{GetPoints()}|{GetTimesCompleted()}";
    }

    
}