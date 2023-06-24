public class Negative : Goal {
    public Negative() {

    }

    public Negative(string name, string description, int points, int timesCompleted) : base(name, description, points, timesCompleted) {

    }
    public override void Display()
    {
        base.Display();
        Console.WriteLine($"This is a Negative Goal. If it is completed it will give negative points.");
    }

    public override string SaveLine()
    {
        return $"Negative|{GetName()}|{GetDescription()}|{GetPoints()}|{GetTimesCompleted()}";
    }

    public override int Calculate() {
        int baseCalculation = base.Calculate();
        return -baseCalculation;
    }
}