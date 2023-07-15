public class Rental : IFileable{
    private int _limit = 7;
    private double _lateFee = 10.00;
    private Vehicle _vehicle;
    private int _vehicleID;
    private int _daysRented = 0;
    private DateTime _dayRented;
    private bool _isReturned = false;
    private DateTime _dayReturned;
    public Rental() {
        _dayRented = DateTime.Today;
    }
    public Rental(Vehicle vehicle, int vehicleID, int rentMonth, int rentDay, int rentYear) {
        _dayRented = new DateTime(rentYear, rentDay, rentMonth);
        DateTime today = DateTime.Today;
        _daysRented = (today - _dayRented).Days;
        _vehicle = vehicle;
        _vehicleID = vehicleID;
    }
    public Rental(Vehicle vehicle, int vehicleID, int rentMonth, int rentDay, int rentYear, int returnMonth, int returnDay, int returnYear) {
        _dayRented = new DateTime(rentYear, rentDay, rentMonth);
        _dayReturned = new DateTime(returnYear, returnMonth, returnDay);
        _daysRented = (_dayReturned - _dayRented).Days;
        _vehicle = vehicle;
        _vehicleID = vehicleID;
        _isReturned = true;
        
    }
    
    
    public void Display() {
        _vehicle.Display();
        string formattedDayRented = _dayRented.ToString("MM dd, yyyy");
        Console.WriteLine($"Day Rented: {formattedDayRented}");
        if (_isReturned) {
            string formattedDayReturned = _dayReturned.ToString("MM dd, yyyy");
            Console.WriteLine($"Day Returned: {formattedDayReturned}");
        } else {
            Console.WriteLine("Not Returned");
        }
        Console.WriteLine($"Price: ${CalculatePrice()}");
        Console.WriteLine();
    }
    public void SetRental() {
        Console.Write("Which vehicle do you want to rent? ");
        _vehicleID = int.Parse(Console.ReadLine()) - 1;

    }
    public void ReturnRental() {
        _isReturned = true;
        _dayReturned = DateTime.Today;
    }
    public int GetVehicleID() {
        return _vehicleID;
    }
    public void SetVehicle(Vehicle vehicle) {
        _vehicle = vehicle;
    }
    public double CalculatePrice() {
        double price = _daysRented * _vehicle.GetPricePerDay();
        if (_daysRented > _limit) {
            int daysOver = _daysRented - _limit;
            price += _lateFee * daysOver;        
            }
        return price;
    }
    public override string Stringify()
    {
        string rentMonth = _dayRented.ToString("MM");
        string rentDay = _dayRented.ToString("dd");
        string rentYear = _dayRented.ToString("yyyy");
        if (!_isReturned) {
            return $"{_vehicleID},{rentMonth},{rentDay},{rentYear},No";
        } else {
            string returnMonth = _dayReturned.ToString("MM");
            string returnDay = _dayReturned.ToString("dd");
            string returnYear = _dayReturned.ToString("yyyy");
            return $"{_vehicleID},{rentMonth},{rentDay},{rentYear},Yes,{returnMonth},{returnDay},{returnYear}";
        }
    }
    public override void CreateFromList(string[] list)
    {
        _vehicleID = int.Parse(list[0]);
        int rentMonth = int.Parse(list[1]);
        int rentDay = int.Parse(list[2]);
        int rentYear = int.Parse(list[3]);
        _dayRented = new DateTime(rentYear, rentMonth, rentDay);
        DateTime today = DateTime.Today;
        string returned = list[4];
        if (returned == "Yes") {
            _isReturned = true;
            int returnMonth = int.Parse(list[5]);
            int returnDay = int.Parse(list[6]);
            int returnYear = int.Parse(list[7]);
            _dayReturned = new DateTime(returnYear, returnMonth, returnDay);
            _daysRented = (_dayReturned - _dayRented).Days;
        } else {
            _daysRented = (today - _dayRented).Days;
        }
    }
}