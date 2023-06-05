public class Menu{
    private Board _board;
    public Menu(Board board){
        _board = board;
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
            DisplayFloor();
            Console.Write("Which floor would you like to go to?: ");
            int floor = Console.ReadLine();
            if(floor != 31){
                Console.WriteLine("Going to " {floor});
            }
            else{
                Console.Write("Please use the VIP elevator");
            }
            break;
            case "VIP":
            Console.WriteLine("Which floor would you like to go to?: ");
            int floor = Console.ReadLine();
            if(floor != 31){
                Console.WriteLine("Going to " {floor});
            }
            else{
                Console.Write("Please enter VIP code: ");
                int code = Console.ReadLine();
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