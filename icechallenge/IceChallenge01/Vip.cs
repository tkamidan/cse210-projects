public class Vip:Elevator{
    string _password = "1234";
    bool _access = false;
    
    public Vip()
    {
        _floor.add(31);
    }

    public void security(){
        Console.Write("Password");
        string answer = console.ReadLine();
        if (answer == _password){
            _access = true;
        }
        else{
            _access = false;
        }
        
        currentFloor = Elevator.getFloor();



    }

}