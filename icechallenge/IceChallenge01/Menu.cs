public class Menu{

    Elevator elevator1 = new Elevator();
    Elevator elevator2 = new Elevator();
    Vip vipElevator = new Vip();
    public Menu(){
;
    }
    public void Display(){
        string response = "";
        string[] options = {"1", "2", "VIP"};
        while(response!=""){
        Console.WriteLine("Welcome to the elevator lobby.");
        Console.Write("Which elevator are you using? 1, 2, or VIP?: ");
        response = Console.ReadLine() ?? String.Empty;
        response = response.ToUpper();
        }
        switch(response){
            case "":
            Environment.Exit(0);
            break;
            case "1" or "2":
            elevator1.DisplayFloors();
            Console.Write("Which floor would you like to go to?: ");
            string floorString = Console.ReadLine() ?? String.Empty;
            int floor = int.Parse(floorString);
            if(floor != 31){
                Console.WriteLine($"Going to {floor}");
            }
            else{
                Console.Write("Please use the VIP elevator");
            }
            break;
            case "VIP":
            Console.WriteLine("Which floor would you like to go to?: ");
            floor = int.Parse(Console.ReadLine() ?? String.Empty);
            if(floor != 31){
                Console.WriteLine($"Going to {floor}");
            }
            else{
                Console.Write("Please enter VIP code: ");
                string? code = Console.ReadLine();
                string VIPcode = vipElevator.GetPassword();
                if(code != VIPcode){
                    Console.WriteLine("Wrong code. Try again or go to a different floor.");
                }
                else{
                    Console.WriteLine("Going to the 31st floor.");
                }
            }
            break;

        }

    }
}