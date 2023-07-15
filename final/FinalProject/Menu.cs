public class Menu {
    private List<Vehicle> _vehicles = new List<Vehicle>();
    private List<Customer> _customers = new List<Customer>();
    private List<Rental> _rentals = new List<Rental>();
    private int _customerIndex = -1;
    private IO _fileManager = new IO();
    private bool _loggedIn = false;
    public void DisplayMainMenu() {
        Load();
        while (!_loggedIn) {
            Console.Clear();
            Console.WriteLine("Welcome to the Vehicle Rental System!");
            Console.Write("Are you a RETURNING customer or a NEW Customer? ");
            string choice1 = Console.ReadLine().ToLower();
            if (choice1 == "returning") {
                Console.Write("What is your full name? ");
                string name = Console.ReadLine();
                Console.Write("What is your address? ");
                string address = Console.ReadLine();
                int count = 0;
                foreach (Customer customer in _customers) {
                    if (name == customer.GetCustomerName() && address == customer.GetCustomerAddress()) {
                        _customerIndex = count;
                        _loggedIn = true;
                        break;
                    }
                    count += 1;
                    
                }
            } else if (choice1 == "new") {
                Customer newCustomer = new Customer();
                newCustomer.SetCustomer();
                _customers.Add(newCustomer);
                int count = 0;
                foreach (Customer customer in _customers) {
                    if (newCustomer.GetCustomerName() == customer.GetCustomerName() && newCustomer.GetCustomerAddress() == customer.GetCustomerAddress()) {
                        _customerIndex = count;
                        _loggedIn = true;
                    } else {
                        count += 1;
                    }
                }
            } else {
                Console.WriteLine("Not a valid option.");
            }
        }
        int choice = 0;
        while (choice != 5) {
            _customers[_customerIndex].Display();
            Console.WriteLine("1. Display Vehicles");
            Console.WriteLine("2. Rent A Vehicle");
            Console.WriteLine("3. Display All Your Rentals");
            Console.WriteLine("4. Return A Rental");
            Console.WriteLine("5. Exit");

            choice = int.Parse(Console.ReadLine());
            switch(choice) {
                case 1: 
                    Console.Clear();
                    DisplayAllVehicles();
                    Console.ReadLine();
                    break;
                case 2:
                    Console.Clear();
                    DisplayAllVehicles();
                    RentVehicle();
                    break;
                case 3:
                    Console.Clear();
                    _customers[_customerIndex].DisplayRentals();
                    Console.ReadLine();
                    break;
                case 4: 
                    Console.WriteLine();
                    List<int> returnedVehicle = _customers[_customerIndex].ReturnRental();
                    int rentalID = returnedVehicle[0];
                    int vehicleID = returnedVehicle[1];
                    _rentals[rentalID].ReturnRental();
                    _vehicles[vehicleID].Return();
                    break;
                case 5:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Not a valid option");
                    break;
            }
        }
        Save();
    }

    public void Save() {
        SaveCustomers();
        SaveVehicles();
        SaveRentals();
    }

    public void SaveCustomers() {
        List<string> lines = new List<string>();
        foreach (Customer customer in _customers) {
            lines.Add(customer.Stringify());
        }
        _fileManager.Write("customers.txt", lines);
    }

    public void SaveVehicles() {
        List<string> lines = new List<string>();
        foreach (Vehicle vehicle in _vehicles) {
            lines.Add(vehicle.Stringify());
        }
        _fileManager.Write("vehicles.txt", lines);
    }

    public void SaveRentals() {
        List<string> lines = new List<string>();
        foreach (Rental rental in _rentals) {
            lines.Add(rental.Stringify());
        }
        _fileManager.Write("rentals.txt", lines);
    }

    public void Load() {
        LoadVehicles();
        LoadRentals();
        LoadCustomers();
    }

    public void LoadVehicles() {
        string[] fileLines = _fileManager.Read("vehicles.txt");
        foreach (string line in fileLines) {
            string[] list = line.Split(",");
            if (list[0] == "Car") {
                Car car = new Car();
                car.CreateFromList(list);
                _vehicles.Add(car);
            }
            else if (list[0] == "Bicycle") {
                Bicycle bicycle = new Bicycle();
                bicycle.CreateFromList(list);
                _vehicles.Add(bicycle);
            }
            else if (list[0] == "Boat") {
                Boat boat = new Boat();
                boat.CreateFromList(list);
                _vehicles.Add(boat);
            }
        }
    }

    public void LoadRentals() {
        string[] fileLines = _fileManager.Read("rentals.txt");
        foreach (string line in fileLines) {
            string[] list = line.Split(",");
            Rental rental = new Rental();
            rental.CreateFromList(list);
            int vehicleID = rental.GetVehicleID();
            rental.SetVehicle(_vehicles[vehicleID]);
            _rentals.Add(rental);
        }
    }

    public void LoadCustomers() {
        string[] fileLines = _fileManager.Read("customers.txt");
        foreach (string line in fileLines) {
            string[] list = line.Split(",");
            Customer customer = new Customer();
            customer.CreateFromList(list);
            List<int> rentalIDs = customer.GetRentalIDs();
            List<Rental> rentals = new List<Rental>();
            foreach (int rentalID in rentalIDs) {
                Rental rental = _rentals[rentalID];
                rentals.Add(rental);
            }
            customer.SetRentals(rentals);
            _customers.Add(customer);
            
        }
    }


    public void DisplayAllVehicles() {
        int vehicleNumber = 1;
        foreach (Vehicle vehicle in _vehicles) {
            Console.Write($"{vehicleNumber}. ");
            vehicle.Display();
            Console.WriteLine();
            vehicleNumber += 1;
        }
    }

    public void RentVehicle() {
        Rental newRental = new Rental();
        newRental.SetRental();
        int vehicleID = newRental.GetVehicleID();
        if (_vehicles[vehicleID].GetIsRented()) {
            Console.WriteLine("Sorry, this item is already rented.");
        } else {
            newRental.SetVehicle(_vehicles[vehicleID]);
            _vehicles[vehicleID].Rent();
            _rentals.Add(newRental);
            int rentalID = _rentals.Count - 1;
            _customers[_customerIndex].AddRentalID(rentalID);
            _customers[_customerIndex].AddRental(_rentals[rentalID]);
        }
    }
}