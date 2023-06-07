public class Vip:Elevator{
    string _password = "1234";
    bool _access = false;
    
    public Vip()
    {
        _floor.Add(31);
    }

    public void security(){
        Console.Write("Password");
        string? answer = Console.ReadLine();
        if (answer == _password){
            _access = true;
        }
        else{
            _access = false;
        }
        
        int currentFloor = GetFloorNumber();



    }

    public string GetPassword() {
        return _password;
    }

}