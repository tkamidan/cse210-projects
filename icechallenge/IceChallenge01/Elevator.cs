using System.Diagnostics;

public class Elevator {
    private bool _door = true;
    private int _floorNumber = 1;
    protected List<int> _floor = new List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30};


    public Elevator() {

    }

    public void OpenDoors() {
        _door = true;
        Console.WriteLine("Doors Opened");
    }

    public void CloseDoors() {
        _door = false;
        Console.WriteLine("Doors Closed");
    }

    public void Move(int floorNumber) {
        if (_door == true) {
            CloseDoors();
        }
        _floorNumber = floorNumber;
        Stopwatch timer = new Stopwatch();
        timer.Start();
        while(timer.Elapsed.TotalSeconds < 40) {
            Console.WriteLine("Elevator Moving...");
        }
        timer.Stop();
        Console.WriteLine($"The Elevator made it to floor {floorNumber}.");
        OpenDoors();
    }

    public void CallElevator(int floorNumber) {
        Console.WriteLine($"Elevator called at floor {floorNumber}.");
        Move(floorNumber);
    }

    public int GetFloorNumber() {
        return _floorNumber;
    }

    public void DisplayFloors() {
        Console.WriteLine("The floors are:");
        foreach (int floor in _floor) {
            Console.WriteLine(floor);
        }
    }
}