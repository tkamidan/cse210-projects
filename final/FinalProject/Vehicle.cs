public abstract class Vehicle : IFileable {
    private string _name;
    private string _color;
    private string _manufacturer;
    private double _pricePerDay;
    private bool _isRented = false;
    private string _rented;
    private string _year;

    public Vehicle() {

    }

    public Vehicle(string name, string color, string manufacturer, double pricePerDay, bool isRented, string year) {
        _name = name;
        _color = color;
        _manufacturer = manufacturer;
        _pricePerDay = pricePerDay;
        _isRented = isRented;
        _year = year;
    }

    public virtual void Display() {
        if (_isRented) {
            _rented = "Yes";
        } 
        else if (!_isRented) {
            _rented = "No";
        }
        Console.Write($"Name of Vehicle: {_name}\nManufacturer: {_manufacturer}\nColor: {_color}\nYear: {_year}\nRented: {_rented}");
    }

    public virtual void SetVehicle() {
        Console.Write("What is the name of this vehicle? ");
        _name = Console.ReadLine();
        Console.Write("What is the manufacturer of the vehicle? ");
        _manufacturer = Console.ReadLine();
        Console.Write("What is the color of the vehicle? ");
        _color = Console.ReadLine();
        Console.Write("What is the year of this vehicle? ");
        _year = Console.ReadLine();
        Console.Write("What is the price per hour of renting this vehicle? ");
        _pricePerDay = double.Parse(Console.ReadLine());
    }

    public void Rent() {
        _isRented = true;
    }
}