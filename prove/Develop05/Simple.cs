public class Simple : Goal {
    private bool _complete = false;
    public Simple() {

    }

    public Simple(string name, string description, int points, bool complete) : base(name, description, points) {
        _complete = complete;
        if (_complete == true) {
            _timesCompleted = 1;
        }
    }

    public override void Display()
    {
        base.Display();
        string completeMessage;
        if (_complete) {
            completeMessage = "is";
        }
        else {
            completeMessage = "is not";
        }
        Console.WriteLine($"This goal is a Simple Goal and can only be completed once. It {completeMessage} completed");
    }

    public override string SaveLine()
    {
        return $"Simple|{GetName()}|{GetDescription()}|{GetPoints()}|{_complete}";
    }

    public override void Complete(int times = 1)
    {
        base.Complete();
        _complete = true;
    }

    public bool GetCompletion() {
        return _complete;
    }
}