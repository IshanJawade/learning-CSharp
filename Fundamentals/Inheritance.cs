using System;

class Vehicle {
    public void VehicleSpecs(){
        Console.WriteLine("It has Engine, Transmission and Suspension,");
    }
}
class Car : Vehicle {
    public void CarSpecs (){
        Console.WriteLine("It aslo has 4 Wheels and 2 or more Doors,");
    }
}
class SportsCar : Car {
    public void SportsCarSpecs() {
        Console.WriteLine("It also Turbo, Rollcage and 2 Doors."); 
    }
}
class MultiLevelInheritance { 
    public static void Main(string[] args){
        SportsCar sc = new SportsCar();     // only Sports car Object is created
        sc.VehicleSpecs();      // Vehicle class properties
        sc.CarSpecs();          // Car class properties
        sc.SportsCarSpecs();    // Sports car properties
    }
}