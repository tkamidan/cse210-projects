public class Car {
    // instances 
    public string brand;
    public int miles;
    public string color;


    // constructor
    public Car(){

    }


    // methods (functions)

    public void move_forward(){
        Console.Write("is running");
    }

    public void displayInfo(){
        Console.WriteLine($"brand: {brand} miles: {miles} Color: {color}");
    }

}