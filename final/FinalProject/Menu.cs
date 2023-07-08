public class Menu {
    private List<Vehicle> _vehicles = new List<Vehicle>{new Car("Model X", "Deep Blue", "Tesla", 50, false, "2022", "4WD"), new Bicycle("500.2 eBike", "Yellow", "Pace", 10, false, "2023", "Adult", true)};
    private List<Customer> _customers;
    private IO _fileManager;
    public void DisplayMainMenu() {
        int choice = 0;
        while (choice != 4) {
            Console.WriteLine("Welcome to the Vehicle Rental Service!");
            Console.WriteLine();
            Console.WriteLine("1. Display Vehicles");
            Console.WriteLine("2. Rent A Vehicle");
            Console.WriteLine("3. Log In");
            Console.WriteLine("4. Quit");
            choice = int.Parse(Console.ReadLine());
            switch(choice) {
                case 1: 
                    DisplayVehicles();
                    break;
                case 2:
                    RentVehicle();
                    break;
                case 3:
                    LogIn();
                    break;
                case 4: 
                    Console.WriteLine("Exitting...");
                    break;
                default:
                    Console.WriteLine("Not a valid option");
                    break;
            }
        }
    }

    public void SetVehicles(List<Vehicle> vehicles) {

    }

    public void SetCustomers(List<Customer> customers) {

    }

    public void Save() {

    }

    public void Load() {

    }

    public void DisplayVehicles() {
        int vehicleNumber = 1;
        foreach (Vehicle vehicle in _vehicles) {
            Console.Write($"{vehicleNumber}. ");
            vehicle.Display();
            Console.WriteLine();
            vehicleNumber += 1;
        }
    }

    public void RentVehicle() {
        Console.Write("What vehicle number do you want to rent? ");
        int vehicleNumber = int.Parse(Console.ReadLine());
        _vehicles[vehicleNumber -  1].Rent();
    }

    public void LogIn() {

    }

    public void DisplayCustomers() {

    }
}