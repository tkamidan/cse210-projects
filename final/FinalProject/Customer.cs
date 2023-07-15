public class Customer : IFileable {
    private string _name;
    private string _address;
    private List<Rental> _rentals = new List<Rental>();
    private List<int> _rentalIDS = new List<int>();
    private double _totalPriceOwed = 0;
    public Customer() {

    }
    public Customer(string name, string address, List<int> rentalIDS) {
        _name = name;
        _address = address;
        _rentalIDS = rentalIDS;
    }
    public void Display() {
        CalculatePrice();
        Console.WriteLine($"Welcome to the Best Rental System, {_name}!");
        Console.WriteLine($"Your address is: {_address}");
        Console.WriteLine($"Lifetime Price Owed: ${_totalPriceOwed}");
        Console.WriteLine();
    }
    public void DisplayRentals() {
        int count = 1;
        foreach (Rental rental in _rentals) {
            Console.Write($"{count}. ");
            rental.Display();
            count += 1;
        }
    }
    public void SetCustomer() {
        Console.Write("What is your full name? ");
        _name = Console.ReadLine();
        Console.Write("What is your full address? ");
        _address = Console.ReadLine();
    }
    public void SetRentals(List<Rental> rentals) {
        _rentals = rentals;
    }
    public List<int> ReturnRental() {
        Console.Write("Which vehicle do you want to return? ");
        int returnedVehicle = int.Parse(Console.ReadLine());
        _rentals[returnedVehicle - 1].ReturnRental();
        int rentalID = _rentalIDS[returnedVehicle - 1];
        int vehicleID = _rentals[returnedVehicle - 1].GetVehicleID();
        return new List<int>{rentalID, vehicleID};
    }
    public void CalculatePrice() {
        _totalPriceOwed = 0;
        foreach (Rental rental in _rentals) {
            _totalPriceOwed += rental.CalculatePrice();
        }
    }
    public void AddRentalID(int rentalID) {
        _rentalIDS.Add(rentalID);
    }
    public void AddRental(Rental rental) {
        _rentals.Add(rental);
    }
    public string GetCustomerName() {
        return _name;
    }
    public string GetCustomerAddress() {
        return _address;
    }
    public List<int> GetRentalIDs() {
        return _rentalIDS;
    } 
    public override string Stringify()
    {
        string stringifiedRentalIDs = (_rentalIDS.Count > 0) ? string.Join(" ", _rentalIDS) : "";
        return $"{_name},{_address},{stringifiedRentalIDs}";
    }

    public override void CreateFromList(string[] list)
    {
        _name = list[0];
        _address = list[1];
        string stringifiedRentalIDs = list[2];
        if (stringifiedRentalIDs == "") {

        }
        else {
            string[] stringArrayRentalIDs = stringifiedRentalIDs.Split(" ");
            foreach (string ID in stringArrayRentalIDs) {
                int rentalID = int.Parse(ID);
                _rentalIDS.Add(rentalID);
            }
        }
    }
}