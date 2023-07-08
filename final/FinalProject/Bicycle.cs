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
        Console.WriteLine($"\nSize: {_size}\nBasket: {_basketYesNo}");
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