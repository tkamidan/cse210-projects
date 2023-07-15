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
        Console.WriteLine($"\nVehicle Type: Car\nWheel Drive: {_wheelDrive}");
    }
    public override void SetVehicle()
    {
        base.SetVehicle();
        Console.Write("What is the wheel drive of this vehicle? ");
        _wheelDrive = Console.ReadLine();
    }
    public override string Stringify()
    {
        return $"Car,{_name},{_color},{_manufacturer},{_pricePerDay},{_isRented},{_year},{_wheelDrive}";
    }
    public override void CreateFromList(string[] list)
    {
        _name = list[1];
        _color = list[2];
        _manufacturer = list[3];
        _pricePerDay = double.Parse(list[4]);
        _isRented = bool.Parse(list[5]);
        _year = list[6];
        _wheelDrive = list[7];
    }
}