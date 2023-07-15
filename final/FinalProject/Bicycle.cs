public class Bicycle : Vehicle {
    private string _size;
    private string _basketYesNo;
    private bool _basket;
    public Bicycle() {

    }
    public Bicycle(string name, string color, string manufacturer, double pricePerDay, bool isRented, string year, string size, bool basket) : base(name, color, manufacturer, pricePerDay, isRented, year) {
        _size = size;
        _basket = basket;
    }

    public override void Display()
    {
        base.Display();
        if (_basket) {
            _basketYesNo = "Yes";
        }
        else {
            _basketYesNo = "No";
        }
        Console.WriteLine($"\nVehicle Type: Bicycle\nSize: {_size}\nBasket: {_basketYesNo}");
    }

    
    public override string Stringify()
    {
        return $"Bicycle,{_name},{_color},{_manufacturer},{_pricePerDay},{_isRented},{_year},{_size},{_basket}";
    }
    public override void CreateFromList(string[] list)
    {
        _name = list[1];
        _color = list[2];
        _manufacturer = list[3];
        _pricePerDay = double.Parse(list[4]);
        _isRented = bool.Parse(list[5]);
        _year = list[6];
        _size = list[7];
        _basket = bool.Parse(list[8]);
    }
}