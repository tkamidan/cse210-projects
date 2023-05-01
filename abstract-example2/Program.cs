using System;

class Program
{
    static void Main(string[] args)
    {
        Car bmw_m3 = new Car();

        bmw_m3.brand = "BMW";
        bmw_m3.miles = 10000;
        bmw_m3.color = "black";

        bmw_m3.displayInfo();
        bmw_m3.move_forward();
    }
}