public class Boat : Vehicle {
    private string _type;
    private string _designCategory;
    public Boat() {

    }
    public Boat(string name, string color, string manufacturer, double pricePerDay, bool isRented, string year, string type, string designCategory) : base(name, color, manufacturer, pricePerDay, isRented, year) {
        _type = type;
        _designCategory = designCategory;
    }
    public override void Display()
    {
        base.Display();
        Console.WriteLine($"\nVehicle Type: Boat\nType: {_type}\nDesign Category: {_designCategory}");
    }
    public override void SetVehicle()
    {
        base.SetVehicle();
    }
    public override string Stringify()
    {
        return $"Boat,{_name},{_color},{_manufacturer},{_pricePerDay},{_isRented},{_year},{_type},{_designCategory}";
    }
    public override void CreateFromList(string[] list)
    {
        _name = list[1];
        _color = list[2];
        _manufacturer = list[3];
        _pricePerDay = double.Parse(list[4]);
        _isRented = bool.Parse(list[5]);
        _year = list[6];
        _type = list[7];
        _designCategory = list[8];
    }
}