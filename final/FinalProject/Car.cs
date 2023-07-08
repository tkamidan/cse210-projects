public class Car : Vehicle {
    private string _wheelDrive;

    public Car() {
        
    }
    public Car(string name, string color, string manufacturer, double pricePerDay, bool isRented, string year, string wheelDrive) : base(name, color, manufacturer, pricePerDay, isRented, year) {
        _wheelDrive = wheelDrive;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"\nWheel Drive: {_wheelDrive}");
    }
    public override void SetVehicle()
    {
        base.SetVehicle();
        Console.Write("What is the wheel drive of this vehicle? ");
        _wheelDrive = Console.ReadLine();
    }
    public override string Stringify()
    {
        throw new NotImplementedException();
    }
    public override void CreateFromList()
    {
        throw new NotImplementedException();
    }
}